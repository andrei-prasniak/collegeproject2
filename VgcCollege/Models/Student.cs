using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VgcCollege.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }


    }
}