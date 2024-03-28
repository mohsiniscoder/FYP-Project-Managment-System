using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Project_Salvation.BL;

namespace Project_Salvation.DL
{
    public class EvaluationCRUD
    {
        public static void AddEvaluation(Evaluation evaluation)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    string query = "INSERT INTO Evaluation (Name, TotalMarks, TotalWeightage) VALUES (@Name, @TotalMarks, @TotalWeightage);";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", evaluation.name);
                        command.Parameters.AddWithValue("@TotalMarks", evaluation.total_marks);
                        command.Parameters.AddWithValue("@TotalWeightage", evaluation.weightage);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Evaluation added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add Evaluation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Function to display Evaluation data in a DataGridView
        public static void DisplayEvaluations(DataGridView grid)
        {
            string query = "SELECT Id, Name, TotalMarks, TotalWeightage FROM Evaluation";

            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();
                    connection.Open();
                    adapter.Fill(dataSet, "Evaluation");
                    // Set the DataGridView's DataSource to the DataTable from the DataSet
                    grid.DataSource = dataSet.Tables["Evaluation"];
                    grid.Columns["Id"].HeaderText = "Evaluation ID";
                    grid.Columns["Name"].HeaderText = "Name";
                    grid.Columns["TotalMarks"].HeaderText = "Total Marks";
                    grid.Columns["TotalWeightage"].HeaderText = "Total Weightage";
                    grid.ColumnHeadersHeight = 40;
                    grid.Font = new Font("Verdana", 12);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
