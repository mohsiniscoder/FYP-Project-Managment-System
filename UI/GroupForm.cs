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
    public partial class GroupForm : MyBaseForm
    {
        private string current_user;
        public GroupForm(string user)
        {
            InitializeComponent();
            current_user = user;
            label1.Text = user;
        }

        private void add_group_Click(object sender, EventArgs e)
        {
        }

        private void back_to_main_page_Click(object sender, EventArgs e)
        {
        }

        private void add_student_to_group_Click(object sender, EventArgs e)
        {
        }

        private void group_project_Click(object sender, EventArgs e)
        {
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage page = new MainPage(current_user);
            page.ShowDialog();
        }

        private void add_group2_Click(object sender, EventArgs e)
        {
            uc_create_show_groups create_Show_Groups = new uc_create_show_groups();
            Functions.add_user_control(create_Show_Groups, group_panel);
        }

        private void add_student_to_group2_Click(object sender, EventArgs e)
        {
            uc_add_student_to_group_ add_to_group = new uc_add_student_to_group_();
            Functions.add_user_control(add_to_group, group_panel);
        }

        private void group_project2_Click(object sender, EventArgs e)
        {
            uc_group_project group_pr = new uc_group_project();
            Functions.add_user_control(group_pr, group_panel);
        }

        private void delete_groups_Click(object sender, EventArgs e)
        {

        }

        private void group_control_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delete_groups2_Click(object sender, EventArgs e)
        {
            uc_delete_groups delete_Groups = new uc_delete_groups();
            Functions.add_user_control(delete_Groups, group_panel);
        }
    }
}
