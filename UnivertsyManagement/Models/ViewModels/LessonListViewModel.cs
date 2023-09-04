using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivertsyManagement.Models.Concrete;

namespace UnivertsyManagement.Models.ViewModels
{
    public class LessonListViewModel
    {
        public List<AcademicYear> AcademicYears { get; set; }

        public List<Exam> Exams { get; set; }

    }
}