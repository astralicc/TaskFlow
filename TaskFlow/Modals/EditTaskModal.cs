using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskFlow.Models;

namespace TaskFlow.Modals
{
    public partial class EditTaskModal : Form
    {
        private int? _editTaskId = null;

        public EditTaskModal()
        {
            InitializeComponent();
        }

        public EditTaskModal(int taskId)
        {
            InitializeComponent();
            _editTaskId = taskId;

            LoadTaskData();
        }

        private void LoadTaskData()
        {
            using var dbContext = new TaskFlowDbContext();

            var editTask = dbContext.Tasks.Find(_editTaskId);

            if (editTask != null)
            {
                textLabelTitle.Text = editTask.Title;
                textLabelDescription.Text = editTask.Description;

                dtpDueDate.Value = editTask.DueDate.ToDateTime(TimeOnly.MinValue);
                cmbStatus.Text = editTask.Status;
                //dtpDueDate.Value = editTask.DueDate.ToDateTime(TimeOnly.MinValue);
                //dtpDueDate.Format = DateTimePickerFormat.Custom;
                //dtpDueDate.CustomFormat = " ";
            }
        }

        private void EditTaskModal_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using var dbContext = new TaskFlowDbContext();

            var inputTitle = textLabelTitle.Text.Trim();
            var inputDescription = textLabelDescription.Text.Trim();
            var inputStatus = cmbStatus.Text.Trim();
            var inputDueDate = DateOnly.FromDateTime(dtpDueDate.Value);

            if (_editTaskId != null)
            {
                var existingTask = dbContext.Tasks.Find(_editTaskId);

                if (existingTask != null)
                {
                    // Overwrite, so the user know the before and after
                    existingTask.Title = inputTitle;
                    existingTask.Description = inputDescription;
                    existingTask.Status = inputStatus;
                    existingTask.DueDate = inputDueDate;

                    dbContext.Tasks.Update(existingTask);
                }
            }
            else
            {
                // Start updating
                var newTask = new TaskFlow.Models.Task
                {
                    Title = textLabelTitle.Text,
                    Description = textLabelDescription.Text,
                    Status = cmbStatus.Text
                };

                dbContext.Tasks.Add(newTask);
            }

            dbContext.SaveChanges();

            MessageBox.Show(
                "Task successfully updated!",
                "Success!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }

        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {
            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.CustomFormat = "dd/MM/yyyy";
        }
    }
}
