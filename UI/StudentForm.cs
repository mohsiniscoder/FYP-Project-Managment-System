using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Project_Salvation.UI
{
    public partial class StudentForm : MyBaseForm
    {
        private readonly string current_user;
        public StudentForm(string current_user)
        {
            InitializeComponent();
            uc_add_student add_student = new uc_add_student();
            add_user_control(add_student);
            this.current_user = current_user;
            label1.Text = current_user;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contact_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gender_options_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void email_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void last_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void first_name_TextChanged(object sender, EventArgs e)
        {

        }
        private void add_user_control(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            student_panel.Controls.Clear();
            student_panel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void student_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void update_students_Click(object sender, EventArgs e)
        {

        }

        private void add_students_Click(object sender, EventArgs e)
        {
        }

        private void back_to_main_page_Click(object sender, EventArgs e)
        {
        }

        private void delete_student_button_Click(object sender, EventArgs e)
        {
        }

        private void view_students_Click(object sender, EventArgs e)
        {
        }

        private void current_person_name_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage(current_user);
            mainPage.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_students2_Click(object sender, EventArgs e)
        {
            uc_add_student add_student = new uc_add_student();
            add_user_control(add_student);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uc_view_student view_student = new uc_view_student();
            add_user_control(view_student);
        }

        private void update_students2_Click(object sender, EventArgs e)
       {

        }

        private void delete_student_button2_Click(object sender, EventArgs e)
        {
            uc_delete_student delete_student = new uc_delete_student();
            add_user_control(delete_student);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}