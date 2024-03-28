using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Salvation.BL
{
    class Student : Person
    {
        public string registration_number;
        public Student(Person person, string registration_number) : base (person)
        {
            this.registration_number = registration_number;
            this.Id = person.Id;
        }
        public Student(string registration_number, Person person)
            : base(person.FirstName, person.LastName, person.email, person.contact, person.gender, person.DateOfBirth)
        {
            this.Id = person.Id;
            this.registration_number = registration_number;
        }
        public Student()
        {
            
        }
    }
}
