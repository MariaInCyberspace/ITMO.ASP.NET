using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StudentManagement.Models
{
    public class StudentManagementContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Record> Record { get; set; }
    }
}