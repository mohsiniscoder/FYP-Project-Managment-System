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
    public partial class uc_delete_groups : UserControl
    {
        public uc_delete_groups()
        {
            InitializeComponent();
        }

        private void delete_group_Click(object sender, EventArgs e)
        {
            int gid = Convert.ToInt32(id.Text.Trim());
            if(Functions.ShowConfirmation("Are you sure you want to delete the Group?\nIt will delete the Groups of students and project assigned with that Group", "Warning"))
            {
                GroupCRUD.DeleteGroup(gid);
            }
        }
    }
}
