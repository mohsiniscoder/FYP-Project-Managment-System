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
    public partial class uc_add_student_to_group_ : UserControl
    {
        public uc_add_student_to_group_()
        {
            InitializeComponent();
        }

        private void add_student_to_group_Click(object sender, EventArgs e)
        {
        }

        private void add_student_to_group2_Click(object sender, EventArgs e)
        {
            int gid = Convert.ToInt32(group_id2.Text.Trim());
            int sid = Convert.ToInt32(student_id2.Text.Trim());
            //validations
            GroupStudent groupStudent = new GroupStudent(gid, sid, DateTime.Now, 3);
            GroupStudentCRUD.InsertGroupStudent(groupStudent);
        }

        private void display_evaluation_button_Click(object sender, EventArgs e)
        {
            DataGridView gr_stu_data_grid = FindForm().Controls.Find("group_student_data_grid", true).FirstOrDefault() as DataGridView;
            GroupStudentCRUD.DisplayGroupStudents(gr_stu_data_grid);
        }
    }
}
