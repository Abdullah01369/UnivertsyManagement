using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Models.Concrete
{
    public class LessonStuationForGradudation
    {
        [Key]
        public int LessonStuationForGradudationID { get; set; }
        public int LessonID { get; set; }
        public virtual Lesson Lesson { get; set; }

        public int StudentID { get; set; }
        public virtual Student Student { get; set; }

        public bool IsPassed { get; set; }
    }
}