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
    public partial class Advisors : MyBaseForm
    {
        private readonly string current_name;
        public Advisors(string current_name)
        {
            InitializeComponent();
            this.current_name = current_name;
            label1.Text = current_name;
        }

        private void add_advisor_Click(object sender, EventArgs e)
        {
        }

        private void advisor_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_to_main_Click(object sender, EventArgs e)
        {
        }

        private void assign_advisors_Click(object sender, EventArgs e)
        {
            
        }

        private void toggle_evaluations_CheckedChanged(object sender, EventArgs e)
        {
            if (toggle_evaluations.Checked)
            {
                // If checked, make the controls visible
                add_evaluations.Visible = true;
                mark_evaluation_against_group.Visible = true;
                update_evaluations.Visible = true;
                delete_evaluation.Visible = true;
            }
            else
            {
                // If unchecked, make the controls invisible
                add_evaluations.Visible = false;
                mark_evaluation_against_group.Visible = false;
                update_evaluations.Visible = false;
                delete_evaluation.Visible = false;
            }
        }

        private void add_evaluations_Click(object sender, EventArgs e)
        {
            uc_add_evaluation add_eva = new uc_add_evaluation();
            Functions.add_user_control(add_eva,advisor_panel);
        }

        private void mark_evaluation_against_group_Click(object sender, EventArgs e)
        {
            uc_mark_evaluations mark_eva = new uc_mark_evaluations();
            Functions.add_user_control(mark_eva, advisor_panel);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void view_advisors_Click(object sender, EventArgs e)
        {

        }

        private void assign_advisors2_Click(object sender, EventArgs e)
        {
            uc_project_advisor_add adv_add = new uc_project_advisor_add();
            Functions.add_user_control(adv_add, advisor_panel);
        }

        private void add_advisor2_Click(object sender, EventArgs e)
        {
            uc_add_advisor uc_Add_Advisor = new uc_add_advisor();
            Functions.add_user_control(uc_Add_Advisor, advisor_panel);
        }

        private void advisor_requests_Click(object sender, EventArgs e)
        {
            uc_advisors_requests requests = new uc_advisors_requests();
            Functions.add_user_control(requests,advisor_panel);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage page = new MainPage(current_name);
            page.ShowDialog();
            this.Close();
        }

        private void fire_advisors_button_Click(object sender, EventArgs e)
        {
            uc_delete_advisor del_advisor = new uc_delete_advisor();
            Functions.add_user_control(del_advisor, advisor_panel);
        }

        private void update_evaluations_Click(object sender, EventArgs e)
        {

        }
    }
}
