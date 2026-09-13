namespace TaskFlow
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            label = new Label();
            dgvTasks = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            ColumnTitle = new DataGridViewTextBoxColumn();
            ColumnDescription = new DataGridViewTextBoxColumn();
            ColumnDueDate = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            taskBindingSource = new BindingSource(components);
            buttonNew = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            labelNoTasks = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(386, 46);
            label.Name = "label";
            label.Size = new Size(375, 39);
            label.TabIndex = 5;
            label.Text = "TaskFlow - Main Form";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvTasks
            // 
            dgvTasks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Columns.AddRange(new DataGridViewColumn[] { No, ColumnTitle, ColumnDescription, ColumnDueDate, ColumnStatus });
            dgvTasks.Location = new Point(60, 126);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.ScrollBars = ScrollBars.Vertical;
            dgvTasks.Size = new Size(1008, 180);
            dgvTasks.TabIndex = 6;
            dgvTasks.CellFormatting += dgvTasks_CellFormatting;
            dgvTasks.DataError += dgvTasks_DataError;
            // 
            // No
            // 
            No.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            No.HeaderText = "No";
            No.MinimumWidth = 6;
            No.Name = "No";
            No.Width = 58;
            // 
            // ColumnTitle
            // 
            ColumnTitle.HeaderText = "Title";
            ColumnTitle.MinimumWidth = 6;
            ColumnTitle.Name = "ColumnTitle";
            ColumnTitle.Width = 125;
            // 
            // ColumnDescription
            // 
            ColumnDescription.FillWeight = 200F;
            ColumnDescription.HeaderText = "Description";
            ColumnDescription.MinimumWidth = 6;
            ColumnDescription.Name = "ColumnDescription";
            ColumnDescription.Width = 125;
            // 
            // ColumnDueDate
            // 
            ColumnDueDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnDueDate.DataPropertyName = "DueDate";
            ColumnDueDate.HeaderText = "Due Date";
            ColumnDueDate.MinimumWidth = 6;
            ColumnDueDate.Name = "ColumnDueDate";
            // 
            // ColumnStatus
            // 
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.MinimumWidth = 6;
            ColumnStatus.Name = "ColumnStatus";
            ColumnStatus.Width = 125;
            // 
            // taskBindingSource
            // 
            taskBindingSource.DataSource = typeof(Models.Task);
            // 
            // buttonNew
            // 
            buttonNew.BackColor = Color.SteelBlue;
            buttonNew.FlatAppearance.BorderColor = Color.CornflowerBlue;
            buttonNew.FlatAppearance.BorderSize = 3;
            buttonNew.FlatStyle = FlatStyle.Flat;
            buttonNew.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonNew.ForeColor = Color.Snow;
            buttonNew.Location = new Point(60, 326);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(187, 58);
            buttonNew.TabIndex = 21;
            buttonNew.Text = "New Task";
            buttonNew.UseVisualStyleBackColor = false;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.LightSalmon;
            buttonUpdate.FlatAppearance.BorderColor = Color.RosyBrown;
            buttonUpdate.FlatAppearance.BorderSize = 3;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.Snow;
            buttonUpdate.Location = new Point(272, 326);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(207, 58);
            buttonUpdate.TabIndex = 22;
            buttonUpdate.Text = "Update Task";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.IndianRed;
            buttonDelete.FlatAppearance.BorderColor = Color.RosyBrown;
            buttonDelete.FlatAppearance.BorderSize = 3;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.Snow;
            buttonDelete.Location = new Point(881, 326);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(187, 58);
            buttonDelete.TabIndex = 24;
            buttonDelete.Text = "Delete Task";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelNoTasks
            // 
            labelNoTasks.AutoSize = true;
            labelNoTasks.BackColor = Color.Transparent;
            labelNoTasks.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNoTasks.ForeColor = Color.White;
            labelNoTasks.Location = new Point(500, 191);
            labelNoTasks.Name = "labelNoTasks";
            labelNoTasks.Size = new Size(149, 36);
            labelNoTasks.TabIndex = 25;
            labelNoTasks.Text = "No Tasks";
            labelNoTasks.TextAlign = ContentAlignment.MiddleCenter;
            labelNoTasks.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1136, 442);
            Controls.Add(labelNoTasks);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonNew);
            Controls.Add(dgvTasks);
            Controls.Add(label);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private DataGridView dgvTasks;
        private BindingSource taskBindingSource;
        private Button buttonNew;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Label labelNoTasks;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn ColumnTitle;
        private DataGridViewTextBoxColumn ColumnDescription;
        private DataGridViewTextBoxColumn ColumnDueDate;
        private DataGridViewTextBoxColumn ColumnStatus;
    }
}