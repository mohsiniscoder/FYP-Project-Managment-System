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
    public partial class uc_create_show_groups : UserControl
    {
        public uc_create_show_groups()
        {
            InitializeComponent();

        }

        private void add_group_button_Click(object sender, EventArgs e)
        { 
            if(Functions.ShowConfirmation("Are you sure want to create a new group? ", "Confirming group creation"))
            {
                GroupCRUD.Add_group();
                //DataGridView group_data_grid = FindForm().Controls.Find("group_data_grid", true).FirstOrDefault() as DataGridView;
            }

        }

        private void uc_create_show_groups_Load(object sender, EventArgs e)
        {

        }

        private void animation2_Click(object sender, EventArgs e)
        {

        }

        private void view_groups_Click(object sender, EventArgs e)
        {
            DataGridView group_data_grid = FindForm().Controls.Find("group_data_grid", true).FirstOrDefault() as DataGridView;
            GroupCRUD.DisplayGroupData(group_data_grid);

        }

        private void group_data_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
