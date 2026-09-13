namespace TaskFlow.Modals
{
    partial class AddTaskModal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label = new Label();
            textLabelDescription = new TextBox();
            labelTaskDescription = new Label();
            textLabelTitle = new TextBox();
            labelTaskTitle = new Label();
            dtpDueDate = new DateTimePicker();
            labelTaskDueDate = new Label();
            newTaskButton = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(145, 44);
            label.Name = "label";
            label.Size = new Size(356, 39);
            label.TabIndex = 9;
            label.Text = "TaskFlow - Add Task";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textLabelDescription
            // 
            textLabelDescription.AcceptsTab = true;
            textLabelDescription.Location = new Point(299, 198);
            textLabelDescription.Multiline = true;
            textLabelDescription.Name = "textLabelDescription";
            textLabelDescription.Size = new Size(250, 92);
            textLabelDescription.TabIndex = 8;
            // 
            // labelTaskDescription
            // 
            labelTaskDescription.AutoSize = true;
            labelTaskDescription.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTaskDescription.ForeColor = Color.White;
            labelTaskDescription.Location = new Point(67, 198);
            labelTaskDescription.Name = "labelTaskDescription";
            labelTaskDescription.Size = new Size(168, 32);
            labelTaskDescription.TabIndex = 7;
            labelTaskDescription.Text = "Description";
            // 
            // textLabelTitle
            // 
            textLabelTitle.AcceptsTab = true;
            textLabelTitle.Location = new Point(299, 127);
            textLabelTitle.Multiline = true;
            textLabelTitle.Name = "textLabelTitle";
            textLabelTitle.Size = new Size(250, 32);
            textLabelTitle.TabIndex = 6;
            // 
            // labelTaskTitle
            // 
            labelTaskTitle.AutoSize = true;
            labelTaskTitle.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTaskTitle.ForeColor = Color.White;
            labelTaskTitle.Location = new Point(67, 127);
            labelTaskTitle.Name = "labelTaskTitle";
            labelTaskTitle.Size = new Size(74, 32);
            labelTaskTitle.TabIndex = 5;
            labelTaskTitle.Text = "Title";
            // 
            // dtpDueDate
            // 
            dtpDueDate.CustomFormat = " ";
            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.Location = new Point(299, 333);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(250, 27);
            dtpDueDate.TabIndex = 10;
            dtpDueDate.ValueChanged += dtpDueDate_ValueChanged;
            // 
            // labelTaskDueDate
            // 
            labelTaskDueDate.AutoSize = true;
            labelTaskDueDate.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTaskDueDate.ForeColor = Color.White;
            labelTaskDueDate.Location = new Point(67, 333);
            labelTaskDueDate.Name = "labelTaskDueDate";
            labelTaskDueDate.Size = new Size(141, 32);
            labelTaskDueDate.TabIndex = 11;
            labelTaskDueDate.Text = "Due Date";
            // 
            // newTaskButton
            // 
            newTaskButton.BackColor = Color.SteelBlue;
            newTaskButton.FlatAppearance.BorderColor = Color.CornflowerBlue;
            newTaskButton.FlatAppearance.BorderSize = 3;
            newTaskButton.FlatStyle = FlatStyle.Flat;
            newTaskButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            newTaskButton.ForeColor = Color.Snow;
            newTaskButton.Location = new Point(214, 406);
            newTaskButton.Name = "newTaskButton";
            newTaskButton.Size = new Size(187, 58);
            newTaskButton.TabIndex = 22;
            newTaskButton.Text = "New Task";
            newTaskButton.UseVisualStyleBackColor = false;
            newTaskButton.Click += newTaskButton_Click;
            // 
            // AddTaskModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(631, 515);
            Controls.Add(newTaskButton);
            Controls.Add(labelTaskDueDate);
            Controls.Add(dtpDueDate);
            Controls.Add(label);
            Controls.Add(textLabelDescription);
            Controls.Add(labelTaskDescription);
            Controls.Add(textLabelTitle);
            Controls.Add(labelTaskTitle);
            Name = "AddTaskModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskFlow - Add Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private TextBox textLabelDescription;
        private Label labelTaskDescription;
        private TextBox textLabelTitle;
        private Label labelTaskTitle;
        private DateTimePicker dtpDueDate;
        private Label labelTaskDueDate;
        private Button newTaskButton;
    }
}