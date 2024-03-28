using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using Project_Salvation.BL;

namespace Project_Salvation.DL
{
    public class GroupEvaluationCRUD
    {
        public static void AddGroupEvaluation(GroupEvaluation groupEvaluation)
        {
            string query = "INSERT INTO GroupEvaluation (GroupId, EvaluationId, ObtainedMarks, EvaluationDate) " +
                           "VALUES (@GroupId, @EvaluationId, @ObtainedMarks, @EvaluationDate)";

            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GroupId", groupEvaluation.group_ID);
                    command.Parameters.AddWithValue("@EvaluationId", groupEvaluation.evaluation_ID);
                    command.Parameters.AddWithValue("@ObtainedMarks", groupEvaluation.obtained_marks);
                    command.Parameters.AddWithValue("@EvaluationDate", groupEvaluation.EvaluationDate);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Group evaluation added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add group evaluation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding group evaluation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
