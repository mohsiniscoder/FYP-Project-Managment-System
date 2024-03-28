using Project_Salvation.BL;
using Project_Salvation.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Project_Salvation.DL
{
    public class ProjectAdvisorCRUD
    {
        public static void Add_Project_Advisor(ProjectAdvisor projectAdvisor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    string query = "INSERT INTO ProjectAdvisor (AdvisorId, ProjectId, AdvisorRole, AssignmentDate) VALUES (@AdvisorId, @ProjectId, @AdvisorRole, @AssignmentDate);";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AdvisorId", projectAdvisor.advisor_ID);
                        command.Parameters.AddWithValue("@ProjectId", projectAdvisor.project_ID);
                        command.Parameters.AddWithValue("@AdvisorRole", projectAdvisor.advisor_role);
                        command.Parameters.AddWithValue("@AssignmentDate", projectAdvisor.assignment_date);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("ProjectAdvisor added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add ProjectAdvisor.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public static void DisplayProjectAdvisors(DataGridView dataGridView)
        {
            string query = "SELECT pr.Title AS ProjectTitle, pa.AdvisorRole, pa.AssignmentDate, a.Id AS AdvisorID, p.FirstName AS AdvisorFirstName, p.Email FROM ProjectAdvisor pa INNER JOIN Advisor a ON pa.AdvisorId = a.Id INNER JOIN Person p ON a.Id = p.Id INNER JOIN Project pr ON pa.ProjectId = pr.Id";
            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();
                    connection.Open();
                    adapter.Fill(dataSet, "ProjectAdvisors");
                    dataGridView.DataSource = dataSet.Tables["ProjectAdvisors"];
                    dataGridView.ColumnHeadersHeight = 40;
                    dataGridView.Font = new Font("Verdana", 8);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}