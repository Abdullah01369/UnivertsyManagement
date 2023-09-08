using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnivertsyManagement.Areas.SuperAdmin.Controllers
{
    [RouteArea("SuperAdmin")]
    public class ExamController : Controller
    {
        // GET: SuperAdmin/Exam
        public ActionResult Index()
        {
            // deneme 
            return View();
        }
    }
}