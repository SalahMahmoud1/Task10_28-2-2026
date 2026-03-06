using EFStudentSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFStudentSystem.Data
{
    internal class ApplicationStudentDBContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<HomeworkSubmission> HomeworkSubmissions {  get; set; }
        public DbSet<StudentCourse> studentCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string ConStr = "Data Source=.;initial Catalog=StudentDB;Integrated Security=True;";
            ConStr += "Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;";
            optionsBuilder.UseSqlServer(ConStr);
        }
    }
}
