using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivertsyManagement.Models.Concrete;
using UnivertsyManagement.Models.Concrete.Connectiondb;

namespace UnivertsyManagement.Repository
{
    public class LessonRepo
    {
        Context context = new Context();

        public List<Student_Lesson> StudentLessonList(string StudentNo, AcademicYear academicYear)
        {
            return context.Student_Lessons.Where(x => x.Student.Student_No == StudentNo && x.AcademicYear.YearOfEducation == academicYear.YearOfEducation && x.AcademicYear.Period == academicYear.Period).ToList();
        }

        public AcademicYear AcademicYearOfLessons()
        {
            //eylul-ocak mart haziran
            var Year = DateTime.Now.Year.ToString();
            string period;
            int currentMonth = DateTime.Now.Month;

            if (currentMonth <= 9 || currentMonth >= 1)
            {
                period = "bahar";

            }
            else
            {
                period = "güz";
            }
            var yearlesson = context.academicYears.Where(x => x.YearOfEducation.Contains(Year + "-") && x.Period == period).FirstOrDefault();

            return yearlesson;
        }

        public List<AcademicYear> ListYear()
        {
            return context.academicYears.ToList();
        }

       


    }
}