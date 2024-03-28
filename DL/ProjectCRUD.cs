using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Salvation.BL;

namespace Project_Salvation.DL
{
    public class ProjectCRUD
    {

        public static int project_add( string proj_name,string proj_desc)
        {
            string query = "INSERT INTO Project (title,description) VALUES (@title,@description)" + "SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(Functions.connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@title", proj_name);
                    command.Parameters.AddWithValue("@description", proj_desc);
                    try
                    {
                        connection.Open();
                        int generatedId = Convert.ToInt32(command.ExecuteScalar());
                        // Returning the generate ID from the function
                        int id = generatedId;
                        return id;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return -1;
                    }
                }
            }
        }
        public static void DisplayProjects(DataGridView grid)
        {
            string query = "SELECT Id, Title, Description FROM Project";

            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();
                    connection.Open();
                    adapter.Fill(dataSet, "Project");

                    // Set the DataGridView's DataSource to the DataTable from the DataSet
                    grid.DataSource = dataSet.Tables["Project"];
                    grid.Columns["Id"].HeaderText = "Project ID";
                    grid.Columns["Title"].HeaderText = "Title";
                    grid.Columns["Description"].HeaderText = "Description";

                    // Set column header height and grid font
                    grid.ColumnHeadersHeight = 40;
                    grid.Font = new Font("Verdana", 12);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public static void project_delete(int proj_id)
        {
            using (SqlConnection connection = new SqlConnection(Functions.connection_string))
            {
                SqlTransaction transaction = null;
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    // Delete associated records in GroupProject table
                    string deleteGroupProjectQuery = "DELETE FROM GroupProject WHERE ProjectId = @projectId";
                    using (SqlCommand deleteGroupProjectCommand = new SqlCommand(deleteGroupProjectQuery, connection, transaction))
                    {
                        deleteGroupProjectCommand.Parameters.AddWithValue("@projectId", proj_id);
                        deleteGroupProjectCommand.ExecuteNonQuery();
                    }

                    // Delete associated records in ProjectAdvisor table
                    string deleteProjectAdvisorQuery = "DELETE FROM ProjectAdvisor WHERE ProjectId = @projectId";
                    using (SqlCommand deleteProjectAdvisorCommand = new SqlCommand(deleteProjectAdvisorQuery, connection, transaction))
                    {
                        deleteProjectAdvisorCommand.Parameters.AddWithValue("@projectId", proj_id);
                        deleteProjectAdvisorCommand.ExecuteNonQuery();
                    }

                    // Delete the project itself
                    string deleteProjectQuery = "DELETE FROM Project WHERE Id = @id";
                    using (SqlCommand deleteProjectCommand = new SqlCommand(deleteProjectQuery, connection, transaction))
                    {
                        deleteProjectCommand.Parameters.AddWithValue("@id", proj_id);
                        int rowsAffected = deleteProjectCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Project and associated records deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Project not found.");
                        }
                    }

                    // Commit the transaction if all queries succeed
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Rollback the transaction if any error occurs
                    transaction?.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
