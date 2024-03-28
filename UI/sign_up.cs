using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Project_Salvation.BL;
using Project_Salvation.DL;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Salvation.UI
{
    public partial class sign_up : MyBaseForm
    {
        private readonly string _connectionString = "Data Source=.;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password = 1234567";

        public sign_up()
        {
            InitializeComponent();
            string key1 = "0987";
            string key2 = "1234";
            string key3 = "3456";
            Functions.disable_text_box(password_contact);
        }

        private void sign_up_Load(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private static readonly object _lockObject = new object();
        private void insert_person_for_sign_up(string firstName, string lastName, string email, string contact, string gender, DateTime dob)
        {
            // Insert data into the Person table and retrieve the generated ID
            int igender = Functions.gender_to_int(gender);
            Person person = new Person(firstName, lastName, contact, email, igender, dob);
            try
            {
                int check = PersonCRUD.add_person(person);
                if (check > 0)
                {
                    MessageBox.Show(person.FirstName + " Successfully Signed-up ");
                }

            }
            catch (Exception ex)
            {
                string errorMessage = "An error occurred: " + ex.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void first_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_to_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.ShowDialog();
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.ShowDialog();
            this.Close();
        }
        private void sign_up_button2_Click(object sender, EventArgs e)
        {
            lock (_lockObject)
            {
                string fname = first_name2.Text.Trim();
                string lname = last_name2.Text.Trim();
                string email = email_id2.Text.Trim();
                string cnumber = password_contact.Text.Trim();
                string gen = gender_options2.Text.Trim();
                string role = role_select2.Text.Trim().ToLower();
                DateTime dob = dateTimePicker2.Value;
                if (Functions.null_check(fname, lname, cnumber, email, gen, role))
                {
                    // Display error message if any required field is empty
                    MessageBox.Show("Please fill out all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (role == "admin")
                    {
                        Functions.make_controls_visible(key2, key_label);
                        string skey = key2.Text.Trim();
                        if ((skey == "1234" || skey == "3456" || skey == "0987"))
                        {
                            if (Functions.check_for_labels(not_valid_email))
                            {
                                if (Functions.check_for_labels(not_valid_password))
                                {
                                    insert_person_for_sign_up(fname, role, email, cnumber, gen, dob);
                                }
                                else
                                {
                                    MessageBox.Show("Length: Password must be between a minimum and maximum length.\nUppercase Letter: Password must contain at least one uppercase letter.\nLowercase Letter: Password must contain at least one lowercase letter.\r\nDigit: Password must contain at least one digit.\nSpecial Character: Password must contain at least one special character.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Information!!!!!!1 \nInvalid Email");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Authetication Key! ");
                        }
                    }
                    else if (role == "advisor")
                    {
                        if (Functions.check_for_labels(not_valid_contact))
                        {
                            if (Functions.check_for_labels(not_valid_email))
                            {
                                insert_person_for_sign_up(fname, role, email, cnumber, gen, dob);
                            }
                        }
                        else
                        {
                            Functions.error_message_box("Enter a Valid Pakistani Contact Number");
                        }
                    }
                    else if (role == "student")
                    {
                        Functions.under_development();
                    }

                }
            }
        }
        private void role_select2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string role = role_select2.SelectedItem.ToString();

            if (role == "Admin")
            {
                Functions.enable_text_box(password_contact);
                Functions.make_controls_visible(key2, key_label);
                password_contact.PasswordChar = '*';
            }
            else if (role == "Advisor")
            {
                Functions.enable_text_box(password_contact);
                password_contact.PasswordChar = '\0';
            }

            else
            {
                Functions.disable_text_box(password_contact);
                Functions.make_controls_invisible(key2, key_label);
            }
        }

        private void email_id2_TextChanged(object sender, EventArgs e)
        {
            string email = email_id2.Text;
            if (!Functions.IsValidEmail(email) || !Functions.IsEmailUnique(email))
            {
                Functions.make_controls_visible(not_valid_email);
            }
            else
            {
                Functions.make_controls_invisible(not_valid_email);
            }
        }

        private void contact_number2_TextChanged(object sender, EventArgs e)
        {
            /*string contact = contact_number2.Text;
            if (!Functions.IsContactNumberValid(contact))
            {
                Functions.make_controls_visible(not_valid_contact);
            }
            else
            {
                Functions.make_controls_invisible(not_valid_contact);
            }*/
        }

        private void gender_options2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void password_contact_TextChanged(object sender, EventArgs e)
        {
            string select = role_select2.SelectedItem.ToString();
            if (select == "Admin")
            {
                string password = password_contact.Text;
                if (!Functions.password_validation(password))
                {
                    Functions.make_controls_visible(not_valid_password);
                }
                else
                {
                    Functions.make_controls_invisible(not_valid_password);
                }
            }
            else
            {
                string contact = password_contact.Text;
                if (!Functions.IsContactNumberValid(contact))
                {
                    Functions.make_controls_visible(not_valid_contact);
                }
                else
                {
                    Functions.make_controls_invisible(not_valid_contact);
                }
            }
        }

        private void not_valid_contact_Click(object sender, EventArgs e)
        {

        }
    }
}
