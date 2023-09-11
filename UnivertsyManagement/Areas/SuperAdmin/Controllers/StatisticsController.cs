using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnivertsyManagement.Areas.SuperAdmin.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: SuperAdmin/Statistics
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StatisticByAcademicianTitle()
        {
            return PartialView("PartialStatisticByAcademicianTitle");
        }
        public ActionResult StatisticByAcademicianPublication()
        {
            return PartialView("PartialStatisticPublicationByAcademician");
        }
    }
}