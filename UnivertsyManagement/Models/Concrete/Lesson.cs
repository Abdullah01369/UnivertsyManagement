using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Models.Concrete
{
    public class Lesson
    {
        [Key]
        public int LessonID { get; set; }
        public string Name { get; set; }
        public string Lesson_Code { get; set; }
        public bool IsActive { get; set; }
        public int CrediofLessons { get; set; }


        public int? SinifID { get; set; }

        public virtual Sinif Sinif { get; set; }

        
        public int? Department_ID { get; set; }
    
        public virtual Department Department { get; set; }

 
        public int? AcademicianID { get; set; }

        public virtual Academician Academician { get; set; }

        public virtual ICollection<Student_Lesson> Student_Lessons { get; set; }
        public virtual ICollection<Exam> Exams { get; set; } 
    }

}