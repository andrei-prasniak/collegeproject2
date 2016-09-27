using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VgcCollege.Models
{
    public class Branch
    {
        public int ID { get; set; }
        public string City { get; set; }

        public virtual ICollection<Enrollment>Enrollments { get; set; }
        public virtual ICollection<Timetable> Timetables { get; set; }
    }
}