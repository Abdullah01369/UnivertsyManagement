using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Web;
using System.Web.Mvc;
using UnivertsyManagement.Models.Concrete;
using UnivertsyManagement.Models.ViewModels;
using UnivertsyManagement.Repository;

namespace UnivertsyManagement.Controllers
{
    public class LessonController : Controller
    {
        LessonRepo lessonRepo = new LessonRepo();
        ExamRepo examRepo = new ExamRepo();

        //public ActionResult LessonList()
        //{

        //    var currentdateofeducation = lessonRepo.AcademicYearOfLessons();
        //    var studentNo = User.Identity.Name;
        //    var listoflessonbystudent = lessonRepo.StudentLessonList(studentNo, currentdateofeducation);

        //    return View(listoflessonbystudent);
        //}

        public List<Student_Lesson> StudentLessonList(AcademicYear academicYear)
        {
            var studentNo = User.Identity.Name;
            var list = lessonRepo.StudentLessonList(studentNo, academicYear);
            return list;
        }

        [HttpGet]
        public JsonResult ListofLessonByParameters(string period, string year)
        {
        
            var studentNo = User.Identity.Name;
            AcademicYear academicYear = new AcademicYear();
            academicYear.Period = period;
            academicYear.YearOfEducation = year;
            var listoflessonbystudent = examRepo.StudentLessonList(studentNo, academicYear);


            var _ExamLessonListViewModel = listoflessonbystudent.Select(d => new ExamLessonListViewModel
            {
                 ButExam_Score=d.ButExam_Score,
                  IsTakenMidterm=d.IsTakenMidterm,
                   MidtermExam_Score=d.MidtermExam_Score,
                   CanTakeBut=d.CanTakeBut,
                    Flagabc=d.FlagAbc.Flag,
                     FinalExam_Score=d.FinalExam_Score,
                      IsChangeableBut=d.IsChangeableBut,
                       IsChangeableFinal=d.IsChangeableFinal,
                        IsChangeableMidterm=d.IsChangeableMidterm,
                         IsConstant=d.IsConstant,
                          IsPassed=d.IsPassed,
                           IsTakenBut=d.IsTakenBut,
                            IsTakenFinal=d.IsTakenFinal,
                             LessonName=d.Lesson.Name,
                               datebut=d.ExamDateDeclareBut,
                                datefinal=d.ExamDateDeclareFinal,
                                 datemid=d.ExamDateDeclareMidterm,
                                  Score=d.Score,
                                   LessonCode=d.Lesson.Lesson_Code
                                
                                
                     
                   
             
            }).ToList();
            return Json(_ExamLessonListViewModel, JsonRequestBehavior.AllowGet);
        }

    }
}