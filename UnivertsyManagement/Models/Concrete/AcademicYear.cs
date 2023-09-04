using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Models.Concrete
{
    public class AcademicYear
    {
        [Key]
        public int AcademicYearID { get; set; }
        public string YearOfEducation { get; set; }
        public string Period { get; set; } // Y, G, B

        public virtual ICollection<Student_Lesson> Student_Lessons { get; set; }
    }
}