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
using System.Collections;
namespace Project_Salvation.DL

{
    class StudentCRUD
    {
        public static Student student;
        public static bool add_student(Student student)
        {
            string query = "INSERT INTO STUDENT (Id,RegistrationNO) VALUES (@Id,@registrationNo)" +
                       "SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(Functions.connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", student.Id);
                    command.Parameters.AddWithValue("@registrationNo", student.registration_number);
                    try
                    {
                        connection.Open();
                        int check = command.ExecuteNonQuery();
                        if (check > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return false;
                    }
                }
            }
        }
        public static bool delete_student(int id)
        {
            string query = "DELETE FROM Student WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(Functions.connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    try
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        int check = command.ExecuteNonQuery();
                        if (check > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
        public static void DisplayStudents(DataGridView grid)
        {
            string query = @"
        SELECT p.Id AS StudentID, p.FirstName, p.LastName, p.Contact, p.Email, p.DateOfBirth, l.Value AS Gender, s.RegistrationNo AS RollNumber
        FROM Person p
        INNER JOIN Student s ON p.Id = s.Id
        INNER JOIN Lookup l ON p.Gender = l.Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();
                    connection.Open();
                    adapter.Fill(dataSet, "Students");
                    // Set the DataGridView's DataSource to the DataTable from the DataSet
                    grid.DataSource = dataSet.Tables["Students"];
                    grid.Columns["StudentID"].HeaderText = "Student ID";
                    grid.Columns["FirstName"].HeaderText = "First Name";
                    grid.Columns["LastName"].HeaderText = "Last Name";
                    grid.Columns["Contact"].HeaderText = "Contact";
                    grid.Columns["Email"].HeaderText = "Email";
                    grid.Columns["DateOfBirth"].HeaderText = "Date of Birth";
                    grid.Columns["Gender"].HeaderText = "Gender";
                    grid.Columns["RollNumber"].HeaderText = "Roll Number";
                    grid.ColumnHeadersHeight = 40;
                    grid.Font = new Font("Verdana", 12);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static int GetStudentIdByEmail(string email)
        {
            int studentId = -1; // Default value in case the student ID is not found

            string query = @"
        SELECT s.Id
        FROM Student s
        INNER JOIN Person p ON s.Id = p.Id
        WHERE p.Email = @Email";

            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        // Execute the query to retrieve the student ID
                        object result = command.ExecuteScalar();

                        // Check if a student ID was found
                        if (result != null && result != DBNull.Value)
                        {
                            studentId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return studentId;
        }
        public static Student GetStudentByEmail(string email)
        {
            Student student = null; // Default value in case the student is not found

            string query = @"
        SELECT s.*, p.FirstName, p.LastName, p.Contact, p.DateOfBirth, p.Gender
        FROM Student s
        INNER JOIN Person p ON s.Id = p.Id
        WHERE p.Email = @Email";

            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        // Execute the query to retrieve the student data
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Create a new Student object and populate its properties
                                student = new Student
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    registration_number = reader.GetString(reader.GetOrdinal("RegistrationNO")),
                                    // Add other properties as needed
                                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                    contact = reader.GetString(reader.GetOrdinal("Contact")),
                                    DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                    gender = reader.GetInt32(reader.GetOrdinal("Gender"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return student;
        }

        public static void DeleteStudentByEmail(string email)
        {
            string deleteStudentQuery = "DELETE FROM Student WHERE Id = (SELECT Id FROM Person WHERE Email = @Email)";

            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(deleteStudentQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No student found with the specified email.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void display_all_students(DataGridView grid)
        {
            string query = @"
        SELECT s.Id, s.RegistrationNo, p.FirstName, p.Contact, p.DateOfBirth, p.Gender, p.Email
        FROM Student s
        INNER JOIN Person p ON s.Id = p.Id 
        INNER JOIN Lookup l ON p.Gender = l.Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();

                    // Fill the DataSet with the query results
                    adapter.Fill(dataSet, "Students");

                    // Set the DataGridView's DataSource to the DataTable from the DataSet
                    grid.DataSource = dataSet.Tables["Students"];

                    // Set column headers
                    grid.Columns["Id"].HeaderText = "Student ID";
                    grid.Columns["RegistrationNo"].HeaderText = "Registration Number";
                    grid.Columns["FirstName"].HeaderText = "First Name";
                    grid.Columns["Contact"].HeaderText = "Contact";
                    grid.Columns["DateOfBirth"].HeaderText = "Date of Birth";
                    grid.Columns["Gender"].HeaderText = "Gender";
                    grid.Columns["Email"].HeaderText = "Email"; // Add email column header

                    // Set DataGridView properties
                    grid.ColumnHeadersHeight = 40;
                    grid.Font = new Font("Verdana", 12);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void display_student(Student student, DataGridView dataGridView)
        {
            // SQL query to select student data and associated person attributes based on the student's Id
            string query = @"
        SELECT s.Id, s.RegistrationNo, p.FirstName, p.LastName, p.Contact, p.DateOfBirth, p.Gender 
        FROM Student s
        INNER JOIN Person p ON s.Id = p.Id 
        WHERE s.Id = @StudentId";

            try
            {
                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the StudentId parameter to the query
                        command.Parameters.AddWithValue("@StudentId", student.Id);

                        // Execute the query and retrieve the data
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Clear existing rows and columns in the DataGridView
                                dataGridView.Rows.Clear();
                                dataGridView.Columns.Clear();

                                // Add columns to the DataGridView for each attribute
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    dataGridView.Columns.Add(reader.GetName(i), reader.GetName(i));
                                }

                                // Add a new row to the DataGridView with the student's attribute values
                                dataGridView.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6));
                                dataGridView.ColumnHeadersHeight = 40;
                                dataGridView.Font = new Font("Verdana", 8);
                            }
                            else
                            {
                                // Handle case when no student is found with the specified Id
                                MessageBox.Show("No student found with the specified Id.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

