using VgcCollege.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace VgcCollege.DAL
{
    public class CollegeContext:DbContext

    {
        public CollegeContext():base ("CollegeContext")
        {
        }
        public DbSet <Student>Students { get; set; }
        public DbSet <Enrollment>Enrollments { get; set; }
        public DbSet <Course>Courses { get; set; }
        public DbSet<Branch>Branches { get; set; }
        public DbSet<Attendance>Attendances { get; set; }
        public DbSet<Timetable>Timetables { get; set; }
        public DbSet<Book>Books { get; set; }
        public DbSet<Condition>Conditions { get; set; }
        public DbSet<Kind>Kinds { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }


    }
}