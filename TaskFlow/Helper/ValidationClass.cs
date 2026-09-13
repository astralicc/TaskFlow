using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFlow.Helper
{
    internal class ValidationClass
    {

        /// <summary>
        /// Validates that specified textboxes are not empty or whitespace.
        /// Displays a warning message and focuses the first invalid textbox.
        /// </summary>
        /// <param name="fields">Tuples containing the TextBox control and its user-friendly display name.</param>
        /// <returns>True if all fields are valid; otherwise, false.</returns>
        // 1. Change TextBox to Control in the parameters
        public static bool ValidateForm(params (Control control, string name)[] fields)
        {
            List<string> invalidFields = new List<string>();

            // 2. Change the tracking variable to Control
            Control firstInvalidControl = null!;

            foreach (var (control, name) in fields)
            {
                // 3. control.Text works for ComboBoxes and DateTimePickers too!
                if (string.IsNullOrWhiteSpace(control?.Text))
                {
                    invalidFields.Add(name);

                    if (firstInvalidControl == null)
                    {
                        firstInvalidControl = control!;
                    }
                }
            }

            if (invalidFields.Count > 0)
            {
                string errorMessage = "The following fields cannot be empty:\n- " + string.Join("\n- ", invalidFields);
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                firstInvalidControl?.Focus();
                return false;
            }

            return true;
        }

        /*
         ===============================================================================
                                        USAGE EXAMPLES
         ===============================================================================

         --- EXAMPLE 1: Single Field Validation ---
         if (!ValidateForm((txtSearch, "Search Keyword")))
             return;


         --- EXAMPLE 2: Multiple Field Validation ---
         bool isValid = ValidateForm(
             (txtFullName, "Full Name"),
             (txtEmail, "Email Address"),
             (txtPassword, "Password")
         );
         if (!isValid) return;


         --- EXAMPLE 3: Guard Clause Execution Pattern ---
         private void btnSave_Click(object sender, EventArgs e)
         {
             // 1. Empty check
             if (!ValidateForm((txtTitle, "Title"), (txtEmail, "Email"))) 
                 return;

             // 2. Format check
             if (!txtEmail.Text.Trim().Contains("@"))
             {
                 MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 txtEmail.Focus();
                 return;
             }

             // 3. Database execution
             SaveData();
         }
        */

    }
}
