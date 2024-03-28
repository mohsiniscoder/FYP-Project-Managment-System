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
    public class GroupStudentCRUD
    {
        public static void DisplayGroupStudents(DataGridView grid)
        {
            string query = "SELECT GroupId, StudentId, Status, AssignmentDate FROM GroupStudent";

            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();
                    connection.Open();
                    adapter.Fill(dataSet, "GroupStudent");

                    // Set the DataGridView's DataSource to the DataTable from the DataSet
                    grid.DataSource = dataSet.Tables["GroupStudent"];
                    grid.Columns["GroupId"].HeaderText = "Group ID";
                    grid.Columns["StudentId"].HeaderText = "Student ID";
                    grid.Columns["Status"].HeaderText = "Status";
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
