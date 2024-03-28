using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Salvation.BL
{
    public class Evaluation
    {
        public int evaluation_ID { get; set; }
        public string name { get; set; }
        public int total_marks { get; set; }
        public int weightage { get; set; }

        public Evaluation(string name , int total_marks, int weightage )
        {
            this.name = name;
            this.total_marks = total_marks;
            this.weightage = weightage;
        }
    }
}
