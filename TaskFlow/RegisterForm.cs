using TaskFlow.Helper;
using TaskFlow.Models;

namespace TaskFlow
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // VALIDATION
            if (!ValidationClass.ValidateForm(
                (textLabelName, "Full Name"),
                (textLabelEmail, "Email")
            )) return;

            // VARIABLES
            using var dbContext = new TaskFlowDbContext();

            string inputName = textLabelName.Text.Trim();
            string inputEmail = textLabelEmail.Text.Trim();

            // VALIDATION VARIABLES
            bool isExists = dbContext.Users.Any(user => user.Email == inputEmail);

            if (isExists)
            {
                MessageBox.Show(
                    "Email already exists!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // INSERT
            var newUser = new User
            {
                FullName = inputName,
                Email = inputEmail,
            };

            dbContext.Add(newUser);
            dbContext.SaveChanges();

            MessageBox.Show(
                "Registration successfull!",
                "Success!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            textLabelName.Clear();
            textLabelEmail.Clear();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
