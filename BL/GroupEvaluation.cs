using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Salvation.BL
{
    public class GroupEvaluation
    {
        public int group_ID { get; set; }
        public int evaluation_ID { get; set; }
        public int obtained_marks { get; set; }
        public DateTime EvaluationDate { get; set; }
        public GroupEvaluation(int group_ID , int evaluation_ID,int obtained_marks,DateTime dateTime)
        {
            this.group_ID = group_ID;
            this.evaluation_ID = evaluation_ID;
            this.obtained_marks = obtained_marks;
            this.EvaluationDate = dateTime;
        }
    }
}
