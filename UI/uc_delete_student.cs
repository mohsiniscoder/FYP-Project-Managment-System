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
    public partial class uc_delete_student : UserControl
    {
        public uc_delete_student()
        {
            InitializeComponent();
        }

        private void delete_student_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewStudents2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void view_student2_Click(object sender, EventArgs e)
        {
            Student student = StudentCRUD.GetStudentByEmail(email_id2.Text);
            if (student != null)
            {
                DataGridView dataGridViewStudents = FindForm().Controls.Find("dataGridViewStudents2", true).FirstOrDefault() as DataGridView;
                StudentCRUD.display_student(student, dataGridViewStudents);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void email_id2_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_student2_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user confirms the deletion, proceed with the deletion
            if (result == DialogResult.Yes)
            {
                // Add your code here to delete the student
                StudentCRUD.DeleteStudentByEmail(email_id2.Text);
            }
            // If the user cancels the deletion, do nothing
            else
            {
                // Optional: Provide feedback to the user, such as a message box or status update
                MessageBox.Show("Deletion canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
