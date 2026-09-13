namespace TaskFlow.Modals
{
    partial class EditTaskModal
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
            labelTaskDueDate = new Label();
            dtpDueDate = new DateTimePicker();
            label = new Label();
            textLabelDescription = new TextBox();
            labelTaskDescription = new Label();
            textLabelTitle = new TextBox();
            labelTaskTitle = new Label();
            buttonUpdate = new Button();
            labelStatus = new Label();
            cmbStatus = new ComboBox();
            SuspendLayout();
            // 
            // labelTaskDueDate
            // 
            labelTaskDueDate.AutoSize = true;
            labelTaskDueDate.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTaskDueDate.ForeColor = Color.White;
            labelTaskDueDate.Location = new Point(74, 336);
            labelTaskDueDate.Name = "labelTaskDueDate";
            labelTaskDueDate.Size = new Size(141, 32);
            labelTaskDueDate.TabIndex = 29;
            labelTaskDueDate.Text = "Due Date";
            // 
            // dtpDueDate
            // 
            dtpDueDate.CustomFormat = "";
            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.Location = new Point(306, 336);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(250, 27);
            dtpDueDate.TabIndex = 28;
            dtpDueDate.ValueChanged += dtpDueDate_ValueChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(152, 47);
            label.Name = "label";
            label.Size = new Size(356, 39);
            label.TabIndex = 27;
            label.Text = "TaskFlow - Add Task";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textLabelDescription
            // 
            textLabelDescription.AcceptsTab = true;
            textLabelDescription.Location = new Point(306, 201);
            textLabelDescription.Multiline = true;
            textLabelDescription.Name = "textLabelDescription";
            textLabelDescription.Size = new Size(250, 92);
            textLabelDescription.TabIndex = 26;
            // 
            // labelTaskDescription
            // 
            labelTaskDescription.AutoSize = true;
            labelTaskDescription.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTaskDescription.ForeColor = Color.White;
            labelTaskDescription.Location = new Point(74, 201);
            labelTaskDescription.Name = "labelTaskDescription";
            labelTaskDescription.Size = new Size(168, 32);
            labelTaskDescription.TabIndex = 25;
            labelTaskDescription.Text = "Description";
            // 
            // textLabelTitle
            // 
            textLabelTitle.AcceptsTab = true;
            textLabelTitle.Location = new Point(306, 130);
            textLabelTitle.Multiline = true;
            textLabelTitle.Name = "textLabelTitle";
            textLabelTitle.Size = new Size(250, 32);
            textLabelTitle.TabIndex = 24;
            // 
            // labelTaskTitle
            // 
            labelTaskTitle.AutoSize = true;
            labelTaskTitle.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTaskTitle.ForeColor = Color.White;
            labelTaskTitle.Location = new Point(74, 130);
            labelTaskTitle.Name = "labelTaskTitle";
            labelTaskTitle.Size = new Size(74, 32);
            labelTaskTitle.TabIndex = 23;
            labelTaskTitle.Text = "Title";
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.LightSalmon;
            buttonUpdate.FlatAppearance.BorderColor = Color.RosyBrown;
            buttonUpdate.FlatAppearance.BorderSize = 3;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.Snow;
            buttonUpdate.Location = new Point(209, 492);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(207, 58);
            buttonUpdate.TabIndex = 31;
            buttonUpdate.Text = "Update Task";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStatus.ForeColor = Color.White;
            labelStatus.Location = new Point(74, 407);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(101, 32);
            labelStatus.TabIndex = 32;
            labelStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Unfinished", "Completed" });
            cmbStatus.Location = new Point(306, 407);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(250, 28);
            cmbStatus.TabIndex = 34;
            // 
            // EditTaskModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(631, 610);
            Controls.Add(cmbStatus);
            Controls.Add(labelStatus);
            Controls.Add(buttonUpdate);
            Controls.Add(labelTaskDueDate);
            Controls.Add(dtpDueDate);
            Controls.Add(label);
            Controls.Add(textLabelDescription);
            Controls.Add(labelTaskDescription);
            Controls.Add(textLabelTitle);
            Controls.Add(labelTaskTitle);
            Name = "EditTaskModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditTaskModal";
            Load += EditTaskModal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTaskDueDate;
        private DateTimePicker dtpDueDate;
        private Label label;
        private TextBox textLabelDescription;
        private Label labelTaskDescription;
        private TextBox textLabelTitle;
        private Label labelTaskTitle;
        private Button buttonUpdate;
        private Label labelStatus;
        private ComboBox cmbStatus;
    }
}