namespace TaskFlow
{
    partial class LoginForm
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
            labelRegister = new Label();
            label3 = new Label();
            loginButton = new Button();
            label = new Label();
            textLabelEmail = new TextBox();
            labelEmail = new Label();
            textLabelName = new TextBox();
            labelName = new Label();
            SuspendLayout();
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            labelRegister.ForeColor = Color.Snow;
            labelRegister.Location = new Point(324, 352);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(124, 31);
            labelRegister.TabIndex = 40;
            labelRegister.Text = "Register";
            labelRegister.TextAlign = ContentAlignment.MiddleCenter;
            labelRegister.Click += registerLabel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16F);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(32, 352);
            label3.Name = "label3";
            label3.Size = new Size(298, 31);
            label3.TabIndex = 39;
            label3.Text = "Don't have an account?";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.MediumTurquoise;
            loginButton.FlatAppearance.BorderColor = Color.Turquoise;
            loginButton.FlatAppearance.BorderSize = 3;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            loginButton.ForeColor = Color.Snow;
            loginButton.Location = new Point(146, 265);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(187, 58);
            loginButton.TabIndex = 37;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(92, 40);
            label.Name = "label";
            label.Size = new Size(293, 39);
            label.TabIndex = 36;
            label.Text = "TaskFlow - Login";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textLabelEmail
            // 
            textLabelEmail.Location = new Point(213, 191);
            textLabelEmail.Multiline = true;
            textLabelEmail.Name = "textLabelEmail";
            textLabelEmail.Size = new Size(164, 32);
            textLabelEmail.TabIndex = 35;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(92, 191);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(91, 32);
            labelEmail.TabIndex = 34;
            labelEmail.Text = "Email";
            // 
            // textLabelName
            // 
            textLabelName.Location = new Point(213, 120);
            textLabelName.Multiline = true;
            textLabelName.Name = "textLabelName";
            textLabelName.Size = new Size(164, 32);
            textLabelName.TabIndex = 33;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(92, 120);
            labelName.Name = "labelName";
            labelName.Size = new Size(93, 32);
            labelName.TabIndex = 32;
            labelName.Text = "Name";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(478, 425);
            Controls.Add(labelRegister);
            Controls.Add(label3);
            Controls.Add(loginButton);
            Controls.Add(label);
            Controls.Add(textLabelEmail);
            Controls.Add(labelEmail);
            Controls.Add(textLabelName);
            Controls.Add(labelName);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskFlow - Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRegister;
        private Label label3;
        private Button loginButton;
        private Label label;
        private TextBox textLabelEmail;
        private Label labelEmail;
        private TextBox textLabelName;
        private Label labelName;
    }
}