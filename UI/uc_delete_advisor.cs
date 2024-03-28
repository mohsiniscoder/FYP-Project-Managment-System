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
    public partial class uc_delete_advisor : UserControl
    {
        public uc_delete_advisor()
        {
            InitializeComponent();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void uc_delete_advisor_Load(object sender, EventArgs e)
        {

        }

        private void fire_advisor_Click(object sender, EventArgs e)
        {
            int advisor_id = Convert.ToInt32(id.Text.Trim());
            AdvisorCRUD.DeleteAdvisor(advisor_id);
        }
    }
}
