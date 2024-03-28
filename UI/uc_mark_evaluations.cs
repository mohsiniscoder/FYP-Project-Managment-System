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
    public partial class uc_mark_evaluations : UserControl
    {
        public uc_mark_evaluations()
        {
            InitializeComponent();
        }

        private void mark_evaluation_Click(object sender, EventArgs e)
        {
            int gid = Convert.ToInt32(group_id.Text.Trim());
            int pid = Convert.ToInt32(evaluation_id.Text.Trim());
            int marks = Convert.ToInt32(obtained_marks.Text.Trim());
            GroupEvaluation groupEvaluation = new GroupEvaluation(gid, pid, marks,DateTime.Now);
            if (groupEvaluation != null)
            {
                GroupEvaluationCRUD.AddGroupEvaluation(groupEvaluation);
            }
            else
            {
                MessageBox.Show("Failed to take evaluation :(");
            }
        }
    }
}
