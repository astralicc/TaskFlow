namespace TaskFlow
{
    partial class RegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            textLabelName = new TextBox();
            textLabelEmail = new TextBox();
            labelEmail = new Label();
            label = new Label();
            loginButton = new Button();
            labelLogin = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(92, 117);
            labelName.Name = "labelName";
            labelName.Size = new Size(93, 32);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // textLabelName
            // 
            textLabelName.Location = new Point(213, 117);
            textLabelName.Multiline = true;
            textLabelName.Name = "textLabelName";
            textLabelName.Size = new Size(164, 32);
            textLabelName.TabIndex = 1;
            // 
            // textLabelEmail
            // 
            textLabelEmail.Location = new Point(213, 188);
            textLabelEmail.Multiline = true;
            textLabelEmail.Name = "textLabelEmail";
            textLabelEmail.Size = new Size(164, 32);
            textLabelEmail.TabIndex = 3;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(92, 188);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(91, 32);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(70, 41);
            label.Name = "label";
            label.Size = new Size(339, 39);
            label.TabIndex = 4;
            label.Text = "TaskFlow - Register";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.MediumTurquoise;
            loginButton.FlatAppearance.BorderColor = Color.Turquoise;
            loginButton.FlatAppearance.BorderSize = 3;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            loginButton.ForeColor = Color.Snow;
            loginButton.Location = new Point(146, 262);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(187, 58);
            loginButton.TabIndex = 20;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            labelLogin.ForeColor = Color.Snow;
            labelLogin.Location = new Point(353, 349);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(85, 31);
            labelLogin.TabIndex = 31;
            labelLogin.Text = "Login";
            labelLogin.TextAlign = ContentAlignment.MiddleCenter;
            labelLogin.Click += labelLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16F);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(31, 349);
            label3.Name = "label3";
            label3.Size = new Size(327, 31);
            label3.TabIndex = 30;
            label3.Text = "Already have an account?";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(478, 425);
            Controls.Add(labelLogin);
            Controls.Add(label3);
            Controls.Add(loginButton);
            Controls.Add(label);
            Controls.Add(textLabelEmail);
            Controls.Add(labelEmail);
            Controls.Add(textLabelName);
            Controls.Add(labelName);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskFlow - Register Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textLabelName;
        private TextBox textLabelEmail;
        private Label labelEmail;
        private Label label;
        private Button loginButton;
        private Label labelLogin;
        private Label label3;
    }
}
