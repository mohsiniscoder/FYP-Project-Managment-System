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
    public partial class uc_group_project : UserControl
    {
        public uc_group_project()
        {
            InitializeComponent();
        }

        private void add_group_project_Click(object sender, EventArgs e)
        {
            int gid = Convert.ToInt32(group_id.Text.Trim());
            int pid = Convert.ToInt32(project_id.Text.Trim());
            DateTime dateTime = DateTime.Now;
            GroupProject groupProject = new GroupProject(pid, gid, dateTime);
            if(groupProject!=null)
            {
                GroupProjectCRUD.InsertGroupProject(groupProject);
            }
            else
            {
                MessageBox.Show("Unable to enter data!Try Again plz :(");
            }
        }

        private void display_group_project_button_Click(object sender, EventArgs e)
        {
            DataGridView gr_pr_data_grid = FindForm().Controls.Find("group_project_grid", true).FirstOrDefault() as DataGridView;
            GroupProjectCRUD.DisplayGroupProjects(gr_pr_data_grid);
        }
    }
}
