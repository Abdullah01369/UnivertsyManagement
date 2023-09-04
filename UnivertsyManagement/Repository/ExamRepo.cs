using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivertsyManagement.Models.Concrete;
using UnivertsyManagement.Models.Concrete.Connectiondb;

namespace UnivertsyManagement.Repository
{
    public class ExamRepo
    {
        Context context = new Context();
        public List<Exam> StudentLessonList(string StudentNo, AcademicYear academicYear)
        {
            return context.exams.Where(x => x.Student.Student_No == StudentNo && x.AcademicYear.YearOfEducation == academicYear.YearOfEducation && x.AcademicYear.Period == academicYear.Period).ToList();
        }
    }
}