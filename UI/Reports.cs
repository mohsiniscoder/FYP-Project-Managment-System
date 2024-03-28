using Project_Salvation.BL;
using Project_Salvation.DL;
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
    public partial class Reports : MyBaseForm
    {
        private string user_name;
        public Reports(string User_name)
        {
            user_name = User_name;
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage page = new MainPage(user_name);
            page.ShowDialog();
            this.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_students2_Click(object sender, EventArgs e)
        {
            string option = report_options.SelectedItem.ToString().Trim().ToLower();
            if(option == "generate student result")
            {
                ReportCRUD.generate_students_result();
            }

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
