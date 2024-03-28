using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Salvation.UI
{
    public partial class MainPage : MyBaseForm
    {
        private readonly string current_name;
        public MainPage(string current_name)
        {
            InitializeComponent();
            this.current_name = current_name;
            current_person_name.Text = current_name;
            this.ControlBox = false;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            //project button
            

            
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            // group button 
            
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            //advisor button
        }

        private void back_to_login_page_Click(object sender, EventArgs e)
        {
           
        }

        private void current_person_name_Click(object sender, EventArgs e)
        {

        }

        private void student_button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm studentForm = new StudentForm(current_name);
            studentForm.ShowDialog();
            this.Close();
        }

        private void group_button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GroupForm form = new GroupForm(current_name);
            form.ShowDialog();
        }

        private void advisor_button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Advisors form = new Advisors(current_name);
            form.ShowDialog();
        }

        private void projects_button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectForm form = new ProjectForm(current_name);
            form.ShowDialog();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If user confirms, log out
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm form = new LoginForm();
                form.ShowDialog();
                this.Close();
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Shapes2_Click(object sender, EventArgs e)
        {

        }

        private void menu_button_background_Click(object sender, EventArgs e)
        {

        }

        private void pdf_reports2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports reports = new Reports(current_name);
            reports.ShowDialog();
            this.Close();
            
        }
    }
}
