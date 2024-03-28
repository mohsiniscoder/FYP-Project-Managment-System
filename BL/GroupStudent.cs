using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Salvation.BL
{
    public class GroupStudent
    {
        public int group_ID { get; set; }
        public int student_ID { get; set; }
        public DateTime assignment_date { get; set; }
        public int status { get; set; }
        public GroupStudent(int group_ID , int student_ID , DateTime assignment_date , int status)
        {
            this.group_ID = group_ID;
            this.student_ID = student_ID;
            this.assignment_date = assignment_date;
            this.status = status;
        }
    }
}
