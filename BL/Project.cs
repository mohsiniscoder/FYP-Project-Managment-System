using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Salvation.BL
{
    public class Project
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string description { get; set; }

        public Project(int ID , string title , string description)
        {
            this.ID = ID;
            this.title = title;
            this.description = description;
        }

    }
}
