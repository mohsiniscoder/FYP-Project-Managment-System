using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Salvation.BL
{
    public class Group
    {
        public int ID { get; set; }
        public DateTime Created_On;
        public List<GroupStudent> students = new List<GroupStudent>();
        public Group(int ID, DateTime Created_On)
        {
            this.ID = ID;
            this.Created_On = Created_On;
        }
    }
}
