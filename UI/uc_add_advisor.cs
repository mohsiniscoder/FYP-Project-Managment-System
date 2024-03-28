using Project_Salvation.BL;
using Project_Salvation.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Salvation.UI
{
    public partial class uc_add_advisor : UserControl
    {
        public uc_add_advisor()
        {
            InitializeComponent();
        }

        private void add_advisor_to_db_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(id.Text.Trim());
            int Salary = Convert.ToInt32(salary.Text.Trim());
            int Designation = Convert.ToInt32(Functions.designation_to_string(designation.SelectedItem.ToString()));
            Person person = PersonCRUD.GetPersonById(ID);
            if (person != null)
            {
                Advisor advisor = new Advisor(person, Designation, Salary);
                AdvisorCRUD.AddAdvisor(advisor);
            }
            else
            {
                MessageBox.Show("Failed to Add the Advisor maybe something is wrong :(");
            }

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
        private void display_advisor_button_Click(object sender, EventArgs e)
        {
            DataGridView adv_grid = FindForm().Controls.Find("advisor_grid", true).FirstOrDefault() as DataGridView;
            AdvisorCRUD.DisplayAllAdvisors(adv_grid);

        }

    }
}
