using Guna.UI2.WinForms;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Salvation.DL
{
    public class Functions
    {
        public static string connection_string { get; } = "Data Source=.;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password = 1234567";


        public static bool ShowConfirmation(string message, string caption)
        {
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
        public static void add_user_control(UserControl userControl,Panel panel_name)
        {
            userControl.Dock = DockStyle.Fill;
            panel_name.Controls.Clear();
            panel_name.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public static int gender_to_int(string gender)
        {
            string lower = gender.ToLower();
            switch (lower)
            {
                case "male":
                    return 1;
                case "female":
                    return 2;
                default:
                    return 3;
            }
        }
        public static int designation_to_string(string designation)
        {
            string designation_L = designation.ToLower();
            switch(designation_L)
            {
                case "lecturer":
                    return 9;
                case "assistant professor":
                    return 8;
                case "associate professor":
                    return 7;
                case "professor":
                    return 6;
                default:
                    return -1;
            }
        }
        public static void make_controls_visible(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Visible = true;
            }
        }
        public static void make_controls_invisible(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Visible = false;
            }
        }

        public static void under_development()
        {
            MessageBox.Show("This service is under development!\nWe are sorry for any inconvenience caused\nFor now use Admin Role instead");
        }
        public static int role_to_int(string role)
        {
            string role_L = role.ToLower();
            switch (role_L)
            {
                case "industry professional":
                    return 10;
                case "main advisor":
                    return 11;
                case "co-advisor":
                    return 12;
                case "industry advisor":
                    return 14;
                default:
                    return -1;
            }
        }

        public static string IntToGender(int gender)
        {

            switch (gender)
            {
                case 1:
                    return "male";
                case 2:
                    return "female";
                default:
                    return "other";
            }
        }
       /* public static void data_grid_adjustment(DataGrid grid)
        {
            grid.ColumnHeadersHeight = 40;
            grid.DefaultCellStyle.Font = new Font("Verdana", 12);
        }*/
        public static bool null_check(params string[] inputs)
        {
            // Check if any input is null or empty
            foreach (var input in inputs)
            {
                if (string.IsNullOrEmpty(input))
                {
                    return true;
                }
            }

            // Additional validation rules can be added here

            return false;
        }
        public static bool IsEmailUnique(string email)
        {
            bool isUnique = false;
            string query = "SELECT COUNT(*) FROM Person WHERE Email = @Email";

            using (SqlConnection connection = new SqlConnection(Functions.connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        if (count == 0)
                        {
                            // Email is unique
                            isUnique = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            return isUnique;
        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsContactNumberValid(string cnumber)
        {
            // Regular expression pattern to match Pakistani contact numbers
            string pattern = @"^03[0-9]{2}-?[0-9]{7}$";

            // Check if the contact number matches the pattern
            if (Regex.IsMatch(cnumber, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void error_message_box(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void clear_text_boxes(params Guna2TextBox[] textBoxes)
        {
            foreach (Guna2TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
        public static void disable_text_box(params Guna2TextBox[] textBoxes)
        {
            foreach (Guna2TextBox textBox in textBoxes)
            {
                textBox.Enabled = false;
            }
        }
        public static void enable_text_box(params Guna2TextBox[] textBoxes)
        {
            foreach (Guna2TextBox textBox in textBoxes)
            {
                textBox.Enabled = true;
            }
        }


        public static bool check_for_labels(params Label[] labels)
        {
            foreach (Label label in labels)
            {
                if (label.Visible == false)
                {
                    return true;
                }
            }
            return false;
        }
        public static void clear_combo_boxes(params ComboBox[] comboBoxes)
        {
            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.SelectedIndex = -1;
            }
        }
        /*public static void close_all_forms()
        {
            // Get all open forms
            FormCollection openForms = Application.OpenForms;

            // Close each form
            foreach (Form form in openForms)
            {
                form.Close();
            }
        }*/
        public static bool password_validation(string password)
        {
            // Minimum and maximum length
            int minLength = 8;
            int maxLength = 20;

            // Regular expressions for password validation
            string uppercaseRegex = @"[A-Z]";
            string lowercaseRegex = @"[a-z]";
            string digitRegex = @"\d";
            string specialCharRegex = @"[\W_]";

            // Check length
            if (password.Length < minLength || password.Length > maxLength)
                return false;

            // Check for uppercase letter
            if (!Regex.IsMatch(password, uppercaseRegex))
                return false;

            // Check for lowercase letter
            if (!Regex.IsMatch(password, lowercaseRegex))
                return false;

            // Check for digit
            if (!Regex.IsMatch(password, digitRegex))
                return false;

            // Check for special character
            if (!Regex.IsMatch(password, specialCharRegex))
                return false;

            // Password meets all criteria
            return true;
        }
        public static bool registration_number_valid(string registrationNumber)
        {
            // Define the regular expression pattern
            string pattern = @"^\d{4}-[A-Za-z]{2}-\d+$";

            // Create a Regex object
            Regex regex = new Regex(pattern);

            // Check if the registration number matches the pattern
            return regex.IsMatch(registrationNumber);
        }

    }
}
