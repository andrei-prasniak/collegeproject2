using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VgcCollege.Models
{
	public class Attendance
	{
        public int ID { get; set; }
        public Boolean Yes { get; set; }
        public int StudentID { get; set; }
        public int TimetableID { get; set; }

        public virtual Student Student { get; set; }
        public virtual Timetable Timetable { get; set; }

	}
}