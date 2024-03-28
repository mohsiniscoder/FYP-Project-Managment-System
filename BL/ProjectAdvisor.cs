using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Salvation.BL
{
    public class ProjectAdvisor
    {
        public int advisor_ID { get; set; }
        public int project_ID { get; set; }
        public int advisor_role { get; set; }
        public DateTime assignment_date { get; set; }
        public ProjectAdvisor(int advisor_ID, int project_ID , int advisor_role, DateTime assignment_date)
        {
            this.advisor_ID = advisor_ID;
            this.project_ID = project_ID;
            this.advisor_role = advisor_role;
            this.assignment_date = assignment_date;
        }
    }
}
