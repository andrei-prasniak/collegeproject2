using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using VgcCollege.Models;

namespace VgcCollege.DAL
{
    public class CollegeInitializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<CollegeContext>

    {
        protected override void Seed(CollegeContext context)
        {
            var Students = new List<Student>
            {
                new Student {ID=1,LastName="Johnson",FirstName="Patrick",Address1="80 Wellpark Grove",Address2="Wellpark",
                City="Galway",County="Galway"},
                new Student {ID=2,LastName="Murphy", FirstName="Tim",Address1="55 Tullyglass Court",Address2="Ballycasey",
                City="Shannon",County="Clare"}
            };
            Students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var Courses = new List<Course>
            {
                new Course {ID=1,Name="Web Development " },
                new Course {ID=2,Name="OOP with Ruby" }
               
            };
            Courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var Enrollments = new List<Enrollment>
            {
                new Enrollment {ID=1,CourseID=1,StudentID=1,BranchID=2,FeePaid=true,Grade=Grade.D },
                new Enrollment {ID=2,CourseID=1,StudentID=2,BranchID=1,FeePaid=true,Grade=Grade.M },
                new Enrollment {ID=3,CourseID=2,StudentID=2,BranchID=1,FeePaid=true,Grade=Grade.P }
            };
            Enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

            var Branches = new List<Branch>
            {
            new Branch {ID=1, City="Galway" },
            new Branch {ID=2, City= "Cork" },
            new Branch {ID=3, City= "Limerick" }
            };
            Branches.ForEach(s => context.Branches.Add(s));
            context.SaveChanges();

            var Timetables = new List<Timetable>
            {
            new Timetable {ID=1,CourseID=1, Time=DateTime.Parse("2015-09-25"),BranchID=2,Lecturer="Patrick Ryan" },
            new Timetable {ID=2,CourseID=2, Time=DateTime.Parse("2015-09-26"),BranchID=1,Lecturer="John Murphy" }
            };
            Timetables.ForEach(s => context.Timetables.Add(s));
            context.SaveChanges();

            var Attendances = new List<Attendance>
            {
            new Attendance {ID =1,Yes=true,StudentID=1,TimetableID=1 },
            new Attendance {ID=2,Yes=true,StudentID=2,TimetableID=2 }
            };
            Attendances.ForEach(s => context.Attendances.Add(s));
            context.SaveChanges();

            var Books = new List<Book>
            {
            new Book {ID=1,Title="Web Development",Author="Brian Ryan",Year=DateTime.Parse("2012"),KindID=1,ConditionID=1,
                     NumberInStock=10,Price=35.45}
            };
            Books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();

            var Kinds = new List<Kind>
            {
            new Kind {ID=1,Description="Handbook" },
            new Kind {ID=2, Description="Exam Paper" },
            new Kind {ID=3,Description="Others" }
            };
            Kinds.ForEach(s => context.Kinds.Add(s));
            context.SaveChanges();

            var Conditions = new List<Condition>
            {
            new Condition {ID=1, State="New" },
            new Condition {ID=2, State="Used" }
            };
            Conditions.ForEach(s => context.Conditions.Add(s));
            context.SaveChanges();

            



            

        }
    }
}