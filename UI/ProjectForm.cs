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
    public partial class ProjectForm : MyBaseForm
    {
        private string current_name;
        public ProjectForm(string current_name)
        {
            InitializeComponent();
            this.current_name = current_name;
            label1.Text = current_name;

        }

        private void add_projects_Click(object sender, EventArgs e)
        {

        }

        private void add_projects_Click_1(object sender, EventArgs e)
        {
           
        }

        private void back_to_main_page_Click(object sender, EventArgs e)
        {
           
        }

        private void delete_projects_Click(object sender, EventArgs e)
        {
           
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage page = new MainPage(current_name);
            page.ShowDialog();
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {

        }

        private void add_projects2_Click(object sender, EventArgs e)
        {
            uc_add_project uc_Add_Project = new uc_add_project();
            Functions.add_user_control(uc_Add_Project, project_control_panel);
        }

        private void delete_projects2_Click(object sender, EventArgs e)
        {
            uc_delete_project del_proj = new uc_delete_project();
            Functions.add_user_control(del_proj, project_control_panel);
        }

        private void edit_project_Click(object sender, EventArgs e)
        {

        }
    }
}
