using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Salvation.BL;

namespace Project_Salvation.DL
{
    public class GroupCRUD
    {
        public static void DeleteGroup(int groupId)
        {
            string deleteGroupProjectQuery = "DELETE FROM GroupProject WHERE GroupId = @GroupId";
            string deleteGroupStudentQuery = "DELETE FROM GroupStudent WHERE GroupId = @GroupId";
            string deleteGroupQuery = "DELETE FROM [Group] WHERE Id = @GroupId";

            // Start a transaction to ensure atomicity
            using (SqlConnection connection = new SqlConnection(Functions.connection_string))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Delete records from GroupProject table
                    using (SqlCommand command = new SqlCommand(deleteGroupProjectQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@GroupId", groupId);
                        command.ExecuteNonQuery();
                    }

                    // Delete records from GroupStudent table
                    using (SqlCommand command = new SqlCommand(deleteGroupStudentQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@GroupId", groupId);
                        command.ExecuteNonQuery();
                    }

                    // Delete record from Group table
                    using (SqlCommand command = new SqlCommand(deleteGroupQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@GroupId", groupId);
                        command.ExecuteNonQuery();
                    }

                    // Commit the transaction if all operations succeed
                    transaction.Commit();
                    MessageBox.Show("Group and associated records deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Rollback the transaction if an exception occurs
                    transaction.Rollback();
                    MessageBox.Show("Error deleting group and associated records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void Add_group()
        {
            string query = "INSERT INTO [Group] (Created_On) VALUES (@CreatedOn)";
            using (SqlConnection connection = new SqlConnection(Functions.connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
                    try
                    {
                        connection.Open();
                        int check = command.ExecuteNonQuery();

                        if (check > 0)
                        {
                            MessageBox.Show("Group Created on " + DateTime.Now);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return;
                    }

                }
            }
        }
        public static void DisplayGroupData(DataGridView grid)
        {
            string query = "SELECT ID, Created_On FROM [Group]";

            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();
                    connection.Open();
                    adapter.Fill(dataSet, "Group");

                    // Set the DataGridView's DataSource to the DataTable from the DataSet
                    grid.DataSource = dataSet.Tables["Group"];
                    grid.Columns["ID"].HeaderText = "Group ID";
                    grid.Columns["Created_On"].HeaderText = "Date Created";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void InsertGroupProject(int projectId, int groupId, DateTime assignmentDate)
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
                    command.Parameters.AddWithValue("@ProjectId", projectId);
                    command.Parameters.AddWithValue("@GroupId", groupId);
                    command.Parameters.AddWithValue("@AssignmentDate", assignmentDate);

                    // Open the connection
                    connection.Open();
                    // Execute the query
                    command.ExecuteNonQuery();
                    // Display success message
                    MessageBox.Show("GroupProject record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error inserting GroupProject record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void InsertGroupStudent(GroupStudent group_student)
        {
            // SQL query to insert into GroupStudent table
            string query = "INSERT INTO GroupStudent (GroupId, StudentId, Status, AssignmentDate) VALUES (@GroupId, @StudentId, @Status, @AssignmentDate)";

            try
            {
                // Create SqlConnection and SqlCommand objects
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@GroupId", group_student.group_ID);
                    command.Parameters.AddWithValue("@StudentId", group_student.student_ID);
                    command.Parameters.AddWithValue("@Status", group_student.status);
                    command.Parameters.AddWithValue("@AssignmentDate", group_student.assignment_date);

                    // Open the connection
                    connection.Open();
                    // Execute the query
                    command.ExecuteNonQuery();
                    // Display success message
                    MessageBox.Show("GroupStudent record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error inserting GroupStudent record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
