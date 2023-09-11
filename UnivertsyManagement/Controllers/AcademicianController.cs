using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnivertsyManagement.Models.ViewModels;
using UnivertsyManagement.Repository;

namespace UnivertsyManagement.Controllers
{
    public class AcademicianController : Controller

    {
        // GET: Academician

        AcademicianRepo AcademicianRepo = new AcademicianRepo();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LayoutPartial()
        {
            var AcademicianMail = User.Identity.Name;

            var academician = AcademicianRepo.AcademicianByMail(AcademicianMail);

            var model = new LayoutSidebarAcademicianViewModel
            {
                department = academician.Department.NameDepartment,
                faculty = academician.Department.Faculty.Faculty_Name,
                mail = academician.AcademicianMail,
                name = academician.Name,
                surname = academician.Surname

            };

            return PartialView("LayoutPartialAcademician", model);
        }


    }
}