using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VgcCollege.Models
{
    public class Timetable
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public DateTime Time { get; set; }
        public int BranchID { get; set; }
        public string Lecturer { get; set; }
        
        public virtual Course Course { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; } 

    }
}