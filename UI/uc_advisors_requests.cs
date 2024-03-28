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
    public partial class uc_advisors_requests : UserControl
    {
        public uc_advisors_requests()
        {
            InitializeComponent();
        }

        private void display_advisor_requests_button_Click(object sender, EventArgs e)
        {
            DataGridView adv_request_grid = FindForm().Controls.Find("advisor_grid", true).FirstOrDefault() as DataGridView;
            AdvisorCRUD.DisplayAdvisorRequests(adv_request_grid);
        }
    }
}
