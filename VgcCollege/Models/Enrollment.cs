using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VgcCollege.Models
{
    public enum Grade
    {
        D,M,P,F,N
    }
    public class Enrollment
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public int BranchID { get; set; }
        public bool FeePaid { get; set; }
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }


    }
}