using Project_Salvation.BL;
using Project_Salvation.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Salvation.UI
{
    public partial class uc_add_student : UserControl
    {
        public uc_add_student()
        {
            InitializeComponent();
        }
       // DataGridView evaluation_data_grid = FindForm().Controls.Find("evaluation_grid", true).FirstOrDefault() as DataGridView;
        //EvaluationCRUD.DisplayEvaluations(evaluation_data_grid);
        private static readonly object _lockObject = new object();
        private void add_student_Click(object sender, EventArgs e)
        {
            lock (_lockObject)
            {
                //(firstname.Text.Length == 0) || (last_name.Text.Length == 0) || (contact_number.Text.Length == 0) || (email_id.Text.Length == 0) || gender_options.Items == null || dateTimePicker2.Value == DateTimePicker.MinimumDateTime
                if (Functions.null_check(firstname2.Text, last_name2.Text, contact_number2.Text, email_id2.Text) || gender_options2 == null || dateTimePicker2.Value == DateTimePicker.MinimumDateTime)
                {
                    MessageBox.Show("PLease Fill in all the details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string selectedGender = gender_options2.SelectedItem.ToString();
                    int igender = Functions.gender_to_int(selectedGender);
                    if (Functions.IsValidEmail(email_id2.Text) && Functions.IsEmailUnique(email_id2.Text))
                    {
                        if (Functions.IsContactNumberValid(contact_number2.Text))
                        {
                            if (Functions.registration_number_valid(registration_number2.Text))
                            {
                                Person person = new Person(firstname2.Text, last_name2.Text, contact_number2.Text, email_id2.Text, igender, dateTimePicker2.Value);
                                int person_id = PersonCRUD.add_person(person);
                                string reg_number = registration_number2.Text.Trim();
                                Student student = new Student(person, reg_number);
                                if (StudentCRUD.add_student(student) && person_id > 0)
                                {
                                    MessageBox.Show(student.FirstName + " Added Successfully! ");
                                }
                                else
                                {
                                    Functions.error_message_box("Failed to add student :(");
                                }
                            }
                            else
                            {
                                Functions.error_message_box("Invalid registration Number!\nRegistration Number is YYYY-AB-number");
                            }
                        }
                        else
                        {
                            Functions.error_message_box("Invalid Contact Number :(");
                        }
                    }
                    else
                    {
                        Functions.error_message_box("Invalid Email!!");
                    }
                }
            }
        }

        private void add_student2_Click(object sender, EventArgs e)
        {

        }
    }
}