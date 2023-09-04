using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Models.Concrete.Connectiondb
{
    public class Context:DbContext
    {
        public Context() : base("name=Context")
        {
         
           
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Academician> academicians { get; set; }
        public DbSet<AcademicYear> academicYears { get; set; }
        public DbSet<Announcements> announcements { get; set; }
        public DbSet<Sinif> Sinif { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Exam> exams { get; set; }
        public DbSet<Faculty> faculties { get; set; }
        public DbSet<Lesson> lessons { get; set; }
        public DbSet<Student_Lesson> Student_Lessons { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<FlagModel> FlagModels { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Gender> Genders { get; set; }
    }
}