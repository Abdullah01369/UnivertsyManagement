using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnivertsyManagement.Models.ViewModels;
using UnivertsyManagement.Repository;

namespace UnivertsyManagement.Controllers
{
    public class ExamController : Controller
    {
        ExamRepo examrepo = new ExamRepo();
        LessonRepo lessonRepo = new LessonRepo();
        LessonListViewModel lessonListViewModel = new LessonListViewModel();
        
        // GET: Exam
        public ActionResult LessonList()
        {

            var currentdateofeducation = lessonRepo.AcademicYearOfLessons();
            var studentNo = User.Identity.Name;
            var listoflessonbystudent = examrepo.StudentLessonList(studentNo, currentdateofeducation);

           var listyear= lessonRepo.ListYear();

            lessonListViewModel.Exams = listoflessonbystudent;
            lessonListViewModel.AcademicYears = listyear;

            return View(lessonListViewModel);
         
        }
    }
}