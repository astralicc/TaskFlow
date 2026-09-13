using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskFlow.Helper;
using TaskFlow.Models;

namespace TaskFlow
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // VALIDATION
            if (!ValidationClass.ValidateForm(
                (textLabelName, "Full Name"),
                (textLabelEmail, "Email")
            )) return;

            using var dbContext = new TaskFlowDbContext();

            string inputName = textLabelName.Text.Trim();
            string inputEmail = textLabelEmail.Text.Trim();

            var matchUser = dbContext.Users.FirstOrDefault(user => user.FullName == inputName && user.Email == inputEmail);

            if (matchUser != null)
            {
                MessageBox.Show(
                    "Logged in!",
                    "Success!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                saveLogin();
            } else
            {
                MessageBox.Show(
                    "User doesn't exists!",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            
        }

        void saveLogin()
        {
            using var dbContext = new TaskFlowDbContext();
            string inputEmail = textLabelEmail.Text.Trim();
            var loggedInUser = dbContext.Users.FirstOrDefault(user => user.Email == inputEmail);
            
            if (loggedInUser != null)
            {
                // SAVE SESSION
                AuthHelper.CurrentUser = loggedInUser;

                // GO TO
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
