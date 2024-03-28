using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Salvation.BL;
using Project_Salvation.DL;
using System.Windows.Forms;

namespace Project_Salvation.UI
{
    public partial class uc_view_student : UserControl
    {
        public uc_view_student()
        {
            InitializeComponent();
        }

        private void view_student_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uc_view_student_Load(object sender, EventArgs e)
        {

        }

        private void view_student2_Click(object sender, EventArgs e)
        {
            DataGridView view_students = FindForm().Controls.Find("dataGridViewStudents2", true).FirstOrDefault() as DataGridView;
            StudentCRUD.display_all_students(view_students);
        }

        private void email_id2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewStudents2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
