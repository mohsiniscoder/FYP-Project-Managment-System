using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Salvation.BL;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace Project_Salvation.DL
{
    public class AdvisorCRUD
    {
        private readonly string _connectionString = "Data Source=.;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password = 1234567";

        public static void DisplayAllAdvisors(DataGridView dataGridView)
        {
            string query = @"
        SELECT a.Id AS AdvisorID, p.FirstName,p.Contact, p.DateOfBirth, p.Gender
        FROM Advisor a
        INNER JOIN Person p ON a.Id = p.Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();
                    connection.Open();
                    adapter.Fill(dataSet, "Advisors");
                    dataGridView.DataSource = dataSet.Tables["Advisors"];
                    dataGridView.ColumnHeadersHeight = 40;
                    dataGridView.Font = new Font("Verdana", 12);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public static void DisplayAdvisorRequests(DataGridView dataGridView)
        {
            string query = @"
            SELECT Id AS Person_Id, Email, Contact, FirstName
            FROM Person
            WHERE LastName = 'advisor'";

            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    dataGridView.ColumnHeadersHeight = 40;
                    dataGridView.Font = new Font("Verdana", 12);
                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridView.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No advisor requests found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void AddAdvisor(Advisor advisor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    string advisorQuery = "INSERT INTO Advisor(Id, Designation, Salary) VALUES(@Id, @Designation, @Salary);";

                    using (SqlCommand advisorCommand = new SqlCommand(advisorQuery, connection))
                    {
                        advisorCommand.Parameters.AddWithValue("@Id", advisor.Id);
                        advisorCommand.Parameters.AddWithValue("@Designation", advisor.Designation);
                        advisorCommand.Parameters.AddWithValue("@Salary", advisor.Salary);

                        connection.Open();
                        int check = advisorCommand.ExecuteNonQuery();
                        connection.Close();

                        if (check > 0)
                        {
                            MessageBox.Show("Advisor added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add advisor.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    public void UpdateAdvisor(Advisor advisor)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                // Update query for the Person table
                string personQuery = "UPDATE Person SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Gender = @Gender, DateOfBirth = @DateOfBirth WHERE Id = @Id;";

                // Update query for the Advisor table
                string advisorQuery = "UPDATE Advisor SET Designation = @Designation, Salary = @Salary WHERE Id = @Id;";

                using (SqlCommand personCommand = new SqlCommand(personQuery, connection))
                using (SqlCommand advisorCommand = new SqlCommand(advisorQuery, connection))
                {
                    // Parameters for the Person table
                    personCommand.Parameters.AddWithValue("@Id", advisor.Id);
                    personCommand.Parameters.AddWithValue("@FirstName", advisor.FirstName);
                    personCommand.Parameters.AddWithValue("@LastName", advisor.LastName);
                    personCommand.Parameters.AddWithValue("@Email", advisor.email);
                    personCommand.Parameters.AddWithValue("@Contact", advisor.contact);
                    personCommand.Parameters.AddWithValue("@Gender", advisor.gender);
                    personCommand.Parameters.AddWithValue("@DateOfBirth", advisor.DateOfBirth);

                    // Parameters for the Advisor table
                    advisorCommand.Parameters.AddWithValue("@Id", advisor.Id);
                    advisorCommand.Parameters.AddWithValue("@Designation", advisor.Designation);
                    advisorCommand.Parameters.AddWithValue("@Salary", advisor.Salary);

                    connection.Open();

                    // Execute the commands
                    personCommand.ExecuteNonQuery();
                    advisorCommand.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }


        /* public void DeleteAdvisor(int id)
         {
             using (SqlConnection connection = new SqlConnection(_connectionString))
             {
                 string query = @"
             DELETE FROM Advisor WHERE Id = @Id;
             DELETE FROM Person WHERE Id = @Id;";

                 using (SqlCommand command = new SqlCommand(query, connection))
                 {
                     command.Parameters.AddWithValue("@Id", id);
                     connection.Open();
                     command.ExecuteNonQuery();
                 }
             }
         }
        */
        public static void DeleteAdvisor(int advisorId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    connection.Open();

                    // Step 1: Delete Advisor from ProjectAdvisor Table
                    string deleteProjectAdvisorQuery = "DELETE FROM ProjectAdvisor WHERE AdvisorId = @AdvisorId";
                    using (SqlCommand command = new SqlCommand(deleteProjectAdvisorQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AdvisorId", advisorId);
                        command.ExecuteNonQuery();
                    }

                    // Step 2: Delete Advisor from Advisor Table
                    string deleteAdvisorQuery = "DELETE FROM Advisor WHERE Id = @AdvisorId";
                    using (SqlCommand command = new SqlCommand(deleteAdvisorQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AdvisorId", advisorId);
                        command.ExecuteNonQuery();
                    }

                    // Step 3: Delete Associated Person Attributes
                    string deletePersonQuery = "DELETE FROM Person WHERE Id = @AdvisorId";
                    using (SqlCommand command = new SqlCommand(deletePersonQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AdvisorId", advisorId);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Advisor and associated data deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting advisor: " + ex.Message);
            }
        }

        public Advisor GetAdvisorById(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string queryAdvisor = "SELECT * FROM Advisor WHERE Id = @Id;";
                string queryPerson = "SELECT * FROM Person WHERE Id = @Id;";

                using (SqlCommand commandAdvisor = new SqlCommand(queryAdvisor, connection))
                using (SqlCommand commandPerson = new SqlCommand(queryPerson, connection))
                {
                    commandAdvisor.Parameters.AddWithValue("@Id", id);
                    commandPerson.Parameters.AddWithValue("@Id", id);

                    connection.Open();

                    // Execute reader for Advisor table
                    SqlDataReader readerAdvisor = commandAdvisor.ExecuteReader();

                    if (readerAdvisor.Read())
                    {
                        int advisorId = readerAdvisor.GetInt32(readerAdvisor.GetOrdinal("Id"));
                        int designation = readerAdvisor.GetInt32(readerAdvisor.GetOrdinal("Designation"));
                        int salary = readerAdvisor.GetInt32(readerAdvisor.GetOrdinal("Salary"));

                        // Close the reader before executing the next query
                        readerAdvisor.Close();

                        // Execute reader for Person table
                        SqlDataReader readerPerson = commandPerson.ExecuteReader();

                        if (readerPerson.Read())
                        {
                            string firstName = readerPerson.GetString(readerPerson.GetOrdinal("FirstName"));
                            string lastName = readerPerson.GetString(readerPerson.GetOrdinal("LastName"));
                            string email = readerPerson.GetString(readerPerson.GetOrdinal("Email"));
                            int gender = readerPerson.GetInt32(readerPerson.GetOrdinal("Gender"));
                            string contact = readerPerson.GetString(readerPerson.GetOrdinal("Contact"));
                            DateTime dateOfBirth = readerPerson.GetDateTime(readerPerson.GetOrdinal("DateOfBirth"));

                            // Initialize a new Advisor object with data from both tables
                     //       return new Advisor(advisorId, firstName, lastName,contact, email, gender, dateOfBirth, designation, salary);
                        }
                    }

                    // Return null if no advisor with the specified ID is found
                    return null;
                }
            }
        }

    }
    /* public void AssignAdvisorToProject(int advisorId, int projectId, string role, DateTime assignmentDate)
     {
         using (SqlConnection connection = new SqlConnection(_connectionString))
         {
             string query = "INSERT INTO ProjectAdvisor(advisor_ID, project_ID, advisor_role, assignment_date) " +
                            "VALUES(@AdvisorId, @ProjectId, @Role, @AssignmentDate);";

             using (SqlCommand command = new SqlCommand(query, connection))
             {
                 command.Parameters.AddWithValue("@AdvisorId", advisorId);
                 command.Parameters.AddWithValue("@ProjectId", projectId);
                 command.Parameters.AddWithValue("@Role", role);
                 command.Parameters.AddWithValue("@AssignmentDate", assignmentDate);

                 connection.Open();
                 command.ExecuteNonQuery();
             }
         }
     }*/

    /*public void UnassignAdvisorFromProject(int advisorId, int projectId)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM ProjectAdvisor WHERE advisor_ID = @AdvisorId AND project_ID = @ProjectId;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AdvisorId", advisorId);
                command.Parameters.AddWithValue("@ProjectId", projectId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }*/

    /*public List<ProjectAdvisor> GetAdvisorsForProject(int projectId)
    {
        List<ProjectAdvisor> advisors = new List<ProjectAdvisor>();

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM ProjectAdvisor WHERE project_ID = @ProjectId;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProjectId", projectId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    advisors.Add(new ProjectAdvisor
                    {
                        advisor_ID = Convert.ToInt32(reader["advisor_ID"]),
                        project_ID = Convert.ToInt32(reader["project_ID"]),
                        advisor_role = reader["advisor_role"].ToString(),
                        assignment_date = Convert.ToDateTime(reader["assignment_date"])
                    });
                }
            }
        }

        return advisors;
    }*/
}