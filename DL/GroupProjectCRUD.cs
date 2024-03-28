using Project_Salvation.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Salvation.DL
{
    public class GroupProjectCRUD
    {
        public static void DisplayGroupProjects(DataGridView grid)
        {
            string query = "SELECT ProjectId, GroupId, AssignmentDate FROM GroupProject";

            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();
                    connection.Open();
                    adapter.Fill(dataSet, "GroupProject");

                    // Set the DataGridView's DataSource to the DataTable from the DataSet
                    grid.DataSource = dataSet.Tables["GroupProject"];
                    grid.Columns["ProjectId"].HeaderText = "Project ID";
                    grid.Columns["GroupId"].HeaderText = "Group ID";
                    grid.Columns["AssignmentDate"].HeaderText = "Assignment Date";

                    // Set column header height and grid font
                    grid.ColumnHeadersHeight = 40;
                    grid.Font = new System.Drawing.Font("Verdana", 12);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public static void InsertGroupProject(GroupProject groupProject)
        {
            // SQL query to insert into GroupProject table
            string query = "INSERT INTO GroupProject (ProjectId, GroupId, AssignmentDate) VALUES (@ProjectId, @GroupId, @AssignmentDate)";
            try
            {
                // Create SqlConnection and SqlCommand objects
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@ProjectId", groupProject.project_ID);
                    command.Parameters.AddWithValue("@GroupId", groupProject.group_ID);
                    command.Parameters.AddWithValue("@AssignmentDate", groupProject.assignment_date);

                    // Open the connection
                    connection.Open();
                    // Execute the query and get the number of rows affected
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if any rows were affected
                    if (rowsAffected > 0)
                    {
                        // Display success message if rows were affected
                        MessageBox.Show("GroupProject record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Display message if no rows were affected
                        MessageBox.Show("No rows inserted. Verify your data and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error inserting GroupProject record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
