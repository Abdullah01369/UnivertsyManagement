using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Models.Concrete
{
    public class Academician

    {
        [Key]
        public int AcademicianID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TC { get; set; }

        public int? GenderID { get; set; }
        public virtual Gender Gender { get; set; }

        public int? TitleId { get; set; }
      
        public virtual Title Title { get; set; }

        public bool IsActive { get; set; }
        public string AccessStatu { get; set; }

        public string AcademicianMail { get; set; }
        public string AcademicianPassword { get; set; }
        public string Birthdate { get; set; }

        public string ImageString { get; set; }

        public int? DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; } 
        public virtual ICollection<Student_Lesson> StudentLessons { get; set; } 
        public virtual ICollection<Exam> Exams { get; set; } 
         
    }
}