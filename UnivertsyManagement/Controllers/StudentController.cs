using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnivertsyManagement.Models.Concrete;
using UnivertsyManagement.Models.ViewModels;
using UnivertsyManagement.Repository;

namespace UnivertsyManagement.Controllers
{
    public class StudentController : Controller
    {
        StudentRepo studentRepo = new StudentRepo();
        AnnouncementsRepo AnnouncementsRepo = new AnnouncementsRepo();
        LessonRepo lessonRepo = new LessonRepo();
        MessageRepo MessageRepo= new MessageRepo();
        // GET: Student
        public ActionResult Index()
        {
            var student = studentRepo.FindStudentWithNo(User.Identity.Name);
            StudentIndexViewModel studentIndexViewModel = new StudentIndexViewModel();
            studentIndexViewModel.Student = student;


            var currentdateofeducation = lessonRepo.AcademicYearOfLessons();
            var studentNo = User.Identity.Name;
            ViewBag.Countlesson = lessonRepo.StudentLessonList(studentNo, currentdateofeducation).Count();


            studentIndexViewModel.Announcements = AnnouncementsRepo.AnnouncementList();



            return View(studentIndexViewModel);
        }

        public ActionResult LayoutPartial()
        {
            var studentNo = User.Identity.Name;

            var student = studentRepo.FindStudentWithNo(studentNo);

            var model = new LayoutSidebarViewModel
            {
                StudentNo = student.Student_No,
                Name = student.Name,
                Surname = student.Surname,
                Gano = student.GANO,
                Depatment = student.Department.NameDepartment
            };

            return PartialView("LayoutPartial", model);
        }

        public ActionResult EditStudent()
        {
            var studentNo = User.Identity.Name;

            var student = studentRepo.FindStudentWithNo(studentNo);

            return View(student);
        }

        [HttpPost]
        public JsonResult EditStudentService(EditStudentViewModel student)
        {
            try
            {
                Student mdl = new Student
                {
                    E_Mail = student.E_Mail,
                    Address = student.Address,
                    Password = student.Password


                };
                var studentNo = User.Identity.Name;
                int id = studentRepo.FindStudentWithNo(studentNo).StudentID;
                studentRepo.EditStudent(id, mdl);
                return Json("1");
            }
            catch (Exception)
            {
                return Json("-1");

                throw;
            }
         
            
        }
        public ActionResult MessageInBox()
        {
            return View();
        }
    }
}