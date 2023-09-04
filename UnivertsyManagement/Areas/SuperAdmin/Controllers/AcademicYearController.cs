using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnivertsyManagement.Areas.SuperAdmin.Controllers
{
    [RouteArea("SuperAdmin")]
    public class AcademicYearController : Controller
    {
        // GET: SuperAdmin/AcademicYear
        public ActionResult Index()
        {
            return View();
        }
    }
}