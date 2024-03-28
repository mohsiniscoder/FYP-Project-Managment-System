using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Project_Salvation.DL
{
    public static class ReportCRUD
    {

        public static void generate_students_result()
        {
            // Create a document
            Document document = new Document();
            try
            {
                PdfWriter.GetInstance(document, new FileStream("StudentReport.pdf", FileMode.Create));
                document.Open();

                // Create a table with 4 columns
                PdfPTable table = new PdfPTable(4);

                using (SqlConnection connection = new SqlConnection(Functions.connection_string))
                {
                    string query = @"SELECT
                        g.Id AS GroupId,
                        SUM(ge.ObtainedMarks) AS TotalObtainedMarks,
                        SUM(pe.TotalMarks) AS TotalMarks,
                        p.Title AS ProjectTitle
                    FROM
                        dbo.[Group] g
                    INNER JOIN
                        dbo.GroupProject gp ON g.Id = gp.GroupId
                    INNER JOIN
                        dbo.Project p ON gp.ProjectId = p.Id
                    INNER JOIN
                        dbo.GroupEvaluation ge ON g.Id = ge.GroupId
                    INNER JOIN
                        dbo.Evaluation pe ON ge.EvaluationId = pe.Id
                    GROUP BY
                        g.Id, p.Title;";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);

                    // Add column headers to the table
                    table.AddCell("Group ID");
                    table.AddCell("Total Obtained Marks");
                    table.AddCell("Total Marks");
                    table.AddCell("Project Title");

                    // Add data to the table
                    foreach (DataRow row in dataTable.Rows)
                    {
                        table.AddCell(row["GroupId"].ToString());
                        table.AddCell(row["TotalObtainedMarks"].ToString());
                        table.AddCell(row["TotalMarks"].ToString());
                        table.AddCell(row["ProjectTitle"].ToString());
                    }

                    // Add the table to the document
                    document.Add(table);
                }
            }
            catch (Exception ex)
            {
                Functions.error_message_box(ex + " Error Occurred!");
            }
            finally
            {
                document.Close();
            }
        }
    }
}
