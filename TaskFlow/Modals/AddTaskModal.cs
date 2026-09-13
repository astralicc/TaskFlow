using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskFlow.Helper;
using TaskFlow.Models;

namespace TaskFlow.Modals
{
    public partial class AddTaskModal : Form
    {
        public AddTaskModal()
        {
            InitializeComponent();
        }

        private void newTaskButton_Click(object sender, EventArgs e)
        {
            if (!ValidationClass.ValidateForm(
                (textLabelTitle, "Title"),
                (textLabelDescription, "Description"),
                (dtpDueDate, "Due Date")
            )) return;

            using var dbContext = new TaskFlowDbContext();

            string inputTitle = textLabelTitle.Text.Trim();
            string inputDescription = textLabelDescription.Text.Trim();
            DateOnly inputDueDate = DateOnly.FromDateTime(dtpDueDate.Value);

            bool isExists = dbContext.Tasks.Any(tasks => tasks.Title == inputTitle);

            if (isExists)
            {
                MessageBox.Show(
                    "Task already exists!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            var newTask = new TaskFlow.Models.Task
            {
                Title = inputTitle,
                Description = inputDescription,
                DueDate = inputDueDate,
                Status = "Unfinished",

                UserId = AuthHelper.CurrentUser!.UserId
            };

            dbContext.Tasks.Add(newTask);
            dbContext.SaveChanges();

            MessageBox.Show(
                "Task successfully added!",
                "Success!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            textLabelTitle.Clear();
            textLabelDescription.Clear();
            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.CustomFormat = " ";

            this.Close();
        }

        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {
            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.CustomFormat = "dd/MM/yyyy";
        }
    }
}
