using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StudentManagement.Models
{
    public class StudentManagementInitializer : DropCreateDatabaseIfModelChanges<StudentManagementContext>
    {
        protected override void Seed(StudentManagementContext context)
        {
            var students = new List<Student>
            {
                new Student{FirstName="Some", LastName="Dude", EntryDate = DateTime.Parse("2021-04-01")},
                new Student{FirstName="Another", LastName="Dude", EntryDate = DateTime.Parse("2021-04-01")}
            };

            students.ForEach(s => context.Student.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
                new Course{CourseId=1000, Title = "Math", Credits=3},
                new Course{CourseId=1001, Title = "CS", Credits=3},
                new Course{CourseId=1002, Title = "Physics", Credits=3}
            };
            courses.ForEach(c => context.Course.Add(c));
            context.SaveChanges();

            var records = new List<Record>
            {
                new Record{StudentId=1, CourseId=1000, Grade=77},
                new Record{StudentId=1, CourseId=1001, Grade=75},
                new Record{StudentId=1, CourseId=1002, Grade=90},
                new Record{StudentId=2, CourseId=1000, Grade=98},
                new Record{StudentId=2, CourseId=1001, Grade=83},
                new Record{StudentId=2, CourseId=1002, Grade=88}
            };
            records.ForEach(e => context.Record.Add(e));

            context.SaveChanges();
        }

    }
}