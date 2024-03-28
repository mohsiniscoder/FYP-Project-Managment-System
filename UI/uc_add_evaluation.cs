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
    public partial class uc_add_evaluation : UserControl
    {
        public uc_add_evaluation()
        {
            InitializeComponent();
        }

        private void uc_add_evaluation_Load(object sender, EventArgs e)
        {

        }

        private void add_evaluation_Click(object sender, EventArgs e)
        {
            string evaluation__name = evaluation_name.Text.Trim();
            int marks = Convert.ToInt32(total_marks.Text.Trim());
            int weightage = Convert.ToInt32(total_weightage.Text.Trim());
            Evaluation evaluation = new Evaluation(evaluation__name, marks, weightage);
            if(evaluation != null)
            {
                EvaluationCRUD.AddEvaluation(evaluation);
            }
            else
            {
                MessageBox.Show("Unable to add Evaluation :( ");
            }
        }

        private void evaluation_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void display_evaluation_button_Click(object sender, EventArgs e)
        {
            DataGridView evaluation_data_grid = FindForm().Controls.Find("evaluation_grid", true).FirstOrDefault() as DataGridView;
            EvaluationCRUD.DisplayEvaluations(evaluation_data_grid);
        }
    }
}
