using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project_Salvation.BL
{
    public class Advisor : Person
    {
        public int Designation { get; set; }
        public int Salary { get; set; }

        public Advisor(Person person,int designation,int Salary)
            : base(person)
        {
            this.Designation = designation;
            this.Salary = Salary;
            this.Id = person.Id;
        }
    }
}
