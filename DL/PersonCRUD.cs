using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Salvation.BL;

namespace Project_Salvation.DL
{
    public class PersonCRUD
    {
        public static int add_person(Person person)
        {
            string person_query = "INSERT INTO [dbo].[Person] ([FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) " +
                       "VALUES (@FirstName, @LastName, @Contact, @Email, @DateOfBirth, @Gender); " +
                       "SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(Functions.connection_string))
            {
                using (SqlCommand command = new SqlCommand(person_query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", person.FirstName);
                    command.Parameters.AddWithValue("@LastName", person.LastName);
                    command.Parameters.AddWithValue("@Contact", person.contact);
                    command.Parameters.AddWithValue("@Gender", person.gender);
                    command.Parameters.AddWithValue("@email", person.email);
                    command.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
                    try
                    {
                        connection.Open();
                        //int check = command.ExecuteNonQuery();

                        //if (check > 0)
                        //{
                        int generatedId = Convert.ToInt32(command.ExecuteScalar());

                        // Assign the generated ID to the person object
                        person.Id = generatedId;
                        return person.Id;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return -1;
                    }

                }
            }
        }
        public static Person GetPersonById(int personId)
        {
            string updateQuery = "UPDATE [dbo].[Person] SET [LastName] = 'hired' WHERE [Id] = @PersonId";

            using (SqlConnection connection = new SqlConnection(Functions.connection_string))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@PersonId", personId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // The update was successful
                            // Now retrieve the updated person information
                            string selectQuery = "SELECT [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender] FROM [dbo].[Person] WHERE [Id] = @PersonId";

                            using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                            {
                                selectCommand.Parameters.AddWithValue("@PersonId", personId);
                                SqlDataReader reader = selectCommand.ExecuteReader();

                                if (reader.Read())
                                {
                                    Person person = new Person
                                    {
                                        Id = personId,
                                        FirstName = reader["FirstName"].ToString(),
                                        LastName = reader["LastName"].ToString(),
                                        contact = reader["Contact"].ToString(),
                                        gender = Convert.ToInt32(reader["Gender"]),
                                        email = reader["Email"].ToString(),
                                        DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"])
                                    };

                                    return person;
                                }
                                else
                                {
                                    return null; // Person not found
                                }
                            }
                        }
                        else
                        {
                            return null; // No rows were updated (Person not found or no change needed)
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return null;
                    }
                }
            }

        }
    }
}
