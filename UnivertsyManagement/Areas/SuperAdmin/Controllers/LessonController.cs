using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnivertsyManagement.Areas.SuperAdmin.Repository;

namespace UnivertsyManagement.Areas.SuperAdmin.Controllers
{
    [RouteArea("SuperAdmin")]
    public class LessonController : Controller
    {
        LessonRepo lessonrepo = new LessonRepo();

        // GET: SuperAdmin/Lesson
        public ActionResult Index()
        {
            var listoflesson = lessonrepo.ListLesson();

            return View(listoflesson);
        }
    }
}