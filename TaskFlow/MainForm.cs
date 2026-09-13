using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskFlow.Helper;
using TaskFlow.Modals;
using TaskFlow.Models;

namespace TaskFlow
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            dgvTasks.AutoGenerateColumns = false;

            dgvTasks.Columns["ColumnTitle"]!.DataPropertyName = "Title";
            dgvTasks.Columns["ColumnDescription"]!.DataPropertyName = "Description";
            dgvTasks.Columns["ColumnDescription"]!.DataPropertyName = "Description";
            dgvTasks.Columns["ColumnStatus"]!.DataPropertyName = "Status";
            dgvTasks.Columns["ColumnDueDate"]!.DataPropertyName = "DueDate";

            LoadTasks();
        }

        private void LoadTasks()
        {
            using var dbContext = new TaskFlowDbContext();

            var userTasks = dbContext.Tasks
                .Where(tasks => tasks.UserId == AuthHelper.CurrentUser!.UserId)
                .ToList();

            dgvTasks.DataSource = userTasks;

            labelNoTasks.Visible = (userTasks.Count == 0);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            using (AddTaskModal addTaskModal = new AddTaskModal())
            {
                addTaskModal.ShowDialog();
            }

            LoadTasks();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow?.DataBoundItem is TaskFlow.Models.Task selectedTask)
            {
                using (EditTaskModal editTaskModal = new EditTaskModal(selectedTask.TaskId))
                {
                    editTaskModal.ShowDialog();
                }

                LoadTasks();
            }
            else
            {
                MessageBox.Show(
                    "Please select a task to edit.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void dgvTasks_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using var dbContext = new TaskFlowDbContext();

            if (dgvTasks.CurrentRow?.DataBoundItem is TaskFlow.Models.Task selectedTask)
            {
                var confirmDeletion = MessageBox.Show(
                    "Are you sure you want to delete this task?",
                    "Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmDeletion == DialogResult.Yes)
                {
                    dbContext.Tasks.Remove(selectedTask);
                    dbContext.SaveChanges();

                    LoadTasks();
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select a valid task to delete!",
                    "Deletion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvTasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current cell belongs to your number column
            if (e.ColumnIndex == 0)
            {
                // e.RowIndex starts at 0, so we add 1 to start counting at 1
                e.Value = e.RowIndex + 1;
            }
        }
    }
}
