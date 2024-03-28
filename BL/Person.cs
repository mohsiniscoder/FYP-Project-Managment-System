using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_Salvation.BL
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        public int gender { get; set; }
        public Person(string FirstName, string LastName, string contact, string email, int gender, DateTime DateOfBirth)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.email = email;
            this.gender = gender;
            this.contact = contact;
            this.DateOfBirth = DateOfBirth;
        }
        public Person(Person person)
        {
            this.Id = person.Id;
            this.FirstName = person.FirstName;
            this.LastName = person.LastName;
            this.email = person.email;
            this.contact = person.contact;
            this.DateOfBirth = person.DateOfBirth;
            this.gender = person.gender;
        }
        public Person()
        {
            
        }
    }
}
