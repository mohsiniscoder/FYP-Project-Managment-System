using Project_Salvation.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Salvation.UI
{
    public partial class LoginForm : MyBaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        /*public static string get_user()
        {
            
        }*/
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
        }
        private bool ValidateCredentials(string email, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Person WHERE Email = @Email AND Contact = @Contact AND lastName = 'admin'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@contact", password);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign_up form = new sign_up();
            form.ShowDialog();
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            if (Functions.ShowConfirmation("Are you show you want to close the application?", "Confirm Closing"))
                this.Close();
            ;
        }

        private void close_box_Click(object sender, EventArgs e)
        {
            if (Functions.ShowConfirmation("Are you show you want to close the application?", "Confirm Closing"))
            {
                //Functions.close_all_forms();
                this.Close();
            }
        }

        private void sign_up_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign_up form = new sign_up();
            form.ShowDialog();
            this.Close();   
        }

        private void login_button2_Click(object sender, EventArgs e)
        {
            string email = email_text_box.Text;
            string password = textBox22.Text;
            // Validate the credentials
            if (ValidateCredentials(email, password))
            {
                MessageBox.Show("Login successful! Welcome :)");
                // Proceed to the next step in your application
                this.Hide();
                MainPage page = new MainPage(email);
                page.ShowDialog();
            }
            else
            {
                Functions.clear_text_boxes(email_text_box, textBox22);
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }

        private void animation_1_Click(object sender, EventArgs e)
        {

        }
    }
}
