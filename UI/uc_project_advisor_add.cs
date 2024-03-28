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
    public partial class uc_project_advisor_add : UserControl
    {
        public uc_project_advisor_add()
        {
            InitializeComponent();
        }

        private void add_project_advisor_Click(object sender, EventArgs e)
        {
            int aid = Convert.ToInt32(advisor_id.Text.Trim());
            int pid = Convert.ToInt32(project_id.Text.Trim());
            int Role = Functions.role_to_int(role.Text);
            DateTime time = DateTime.Now;
            ProjectAdvisor projectAdvisor = new ProjectAdvisor(aid, pid, Role, time);
            if(projectAdvisor != null )
            {
                ProjectAdvisorCRUD.Add_Project_Advisor(projectAdvisor);
            }
            else
            {
                MessageBox.Show("An error has occured while assigning Advisor to the project :(");
            }
        }

        private void display_project_advisor_button_Click(object sender, EventArgs e)
        {
            DataGridView proj_adv_grid = FindForm().Controls.Find("project_advisor_grid", true).FirstOrDefault() as DataGridView;
            ProjectAdvisorCRUD.DisplayProjectAdvisors(proj_adv_grid);
        }
    }
}
