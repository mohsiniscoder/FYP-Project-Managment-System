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
    public partial class uc_add_project : UserControl
    {
        public uc_add_project()
        {
            InitializeComponent();
        }

        private void add_project_button_Click(object sender, EventArgs e)
        {
            string proj_name = project_name.Text.Trim();
            string proj_desc = project_description.Text.Trim();
            int id = ProjectCRUD.project_add(proj_name, proj_desc);
            MessageBox.Show(proj_name + " Id is " + id);
        }

        private void uc_add_project_Load(object sender, EventArgs e)
        {

        }

        private void display_projects_Click(object sender, EventArgs e)
        {
           DataGridView project_data_grid = FindForm().Controls.Find("project_grid", true).FirstOrDefault() as DataGridView;
            ProjectCRUD.DisplayProjects(project_data_grid);
        }

        private void project_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /*private void grid_show()
{
   DataGridView project_data_grid = FindForm().Controls.Find("project_grid)", true).FirstOrDefault() as DataGridView;
   ProjectCRUD.DisplayProjects(project_data_grid);
}*/
    }
}
