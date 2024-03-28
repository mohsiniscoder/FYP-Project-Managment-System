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
    public partial class uc_delete_project : UserControl
    {
        public uc_delete_project()
        {
            InitializeComponent();
        }

        private void delete_project_button_Click(object sender, EventArgs e)
        {
           
        }

        private void delete_project2_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(id.Text.Trim());
            if (Functions.ShowConfirmation("Are you want to Delte ID ?\nThis Operation will Delete The Project as well as Advisors & Students associated with it  ", "Warning"))
            {
                ProjectCRUD.project_delete(pid);
            }
        }
    }
}
