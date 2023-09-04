using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Models.Concrete
{
    public class Student_Lesson
    {
        [Key]
        public int StudentLessonID { get; set; }
        public bool IsActive { get; set; }

    
        public int? LessonID { get; set; }

        public virtual Lesson Lesson { get; set; }

      
        public int? StudentID { get; set; }
 
        public virtual Student Student { get; set; }

      
        public int? AcademicianID { get; set; }

        public virtual Academician Academician { get; set; }

  
        public int? AcademicYearID { get; set; }

        public virtual AcademicYear AcademicYear { get; set; }
    }

}