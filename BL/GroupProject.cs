using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Salvation.BL
{
    public class GroupProject
    {
        public int project_ID;
        public int group_ID;
        public DateTime assignment_date;
        public GroupProject(int project_ID, int group_ID , DateTime assignment_date)
        {
            this.project_ID = project_ID;
            this.group_ID = group_ID;
            this.assignment_date = assignment_date; 
        }
    }
}
