using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnivertsyManagement.Areas.SuperAdmin.Data;
using UnivertsyManagement.Areas.SuperAdmin.Repository;
using UnivertsyManagement.Models.Concrete;

namespace UnivertsyManagement.Areas.SuperAdmin.Controllers
{
    [RouteArea("SuperAdmin")]
    public class AcademicianController : Controller
    {
        AcademicianRepo academicianRepo = new AcademicianRepo();
        // GET: SuperAdmin/Academician
        public ActionResult Index()
        {
            ViewBag.activeacademician = academicianRepo.InfosAdminAcademician()[0]; //aktif
            ViewBag.prof = academicianRepo.InfosAdminAcademician()[1]; //prof
            ViewBag.ag = academicianRepo.InfosAdminAcademician()[2]; //ag
            ViewBag.sum = academicianRepo.InfosAdminAcademician()[3]; // tp
            return View();
        }

        public ActionResult AddAcademician()
        {
            AcademicianAddModelView academicianAddingModel = new AcademicianAddModelView();

            academicianAddingModel.City = academicianRepo.CityList();
            academicianAddingModel.Genders = academicianRepo.GenderList();
            academicianAddingModel.Faculties = academicianRepo.FacultyList();
            academicianAddingModel.Titles = academicianRepo.TitleList();

            return View(academicianAddingModel);
        }

        [HttpGet]
        public JsonResult DepartmentListByFacultyId(int facultyId)
        {
            var list = academicianRepo.DepartmentsListByFacultyId(facultyId);

            var departmentViewModels = list.Select(d => new DepartmentViewModel
            {
                DepartmentID = d.DepartmentID,
                DepartmentName = d.NameDepartment,

            }).ToList();

            return Json(departmentViewModels, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AcademicianAdd(AcademicianAddingModel academician)
        {

            byte[] fileData = new byte[academician.Image.ContentLength];

            academician.Image.InputStream.Read(fileData, 0, academician.Image.ContentLength);

            string base64String = Convert.ToBase64String(fileData);

            var academicianmodel = new Academician
            {

                DepartmentID = academician.DepartmentID,
                TC = academician.TC,
                AcademicianMail = academician.E_Mail,
                Surname = academician.Surname,
                AcademicianPassword = academician.Password,
                Birthdate = academician.BirthDate,
                ImageString = base64String,
                Name = academician.Name,
                GenderID = academician.GenderID,
                TitleId = academician.TitleId



            };

            var val = academicianRepo.AddAcademician(academicianmodel);
            return Json(val);
        }


        public ActionResult SearchAcademician()
        {
            var faclist = academicianRepo.FacultyList();

            return View(faclist);
        }

        [HttpGet]
        public JsonResult SearchAcademicianWithParameters(AcademicianSearchModel searchModel)
        {




            if (!string.IsNullOrEmpty(searchModel.DepartmentID.ToString()))
            {
                var list = academicianRepo.FindAcademicianListbyDepId(searchModel.DepartmentID);
                if (list != null)
                {
                    var ListViewModel = list.Select(d => new AcademicianSearchViewModel
                    {
                         Id=d.AcademicianID,
                        TC = d.TC,
                        AcademicianMail = d.AcademicianMail,
                        Department = d.Department.NameDepartment,
                        Title = d.Title.Name,
                        Birthdate = d.Birthdate,
                        Gender = d.Gender.Code,
                        IsActive = d.IsActive,
                        Name = d.Name,
                        Surname = d.Surname,
                      
                    }).ToList();

                    return Json(ListViewModel, JsonRequestBehavior.AllowGet);

                }
                return Json("0", JsonRequestBehavior.AllowGet);
            }
            else
            {
                var listbyfact = academicianRepo.FindAcademicianListbyFacId(searchModel.FaculyID);
                if (listbyfact != null)
                {
                    return Json(listbyfact, JsonRequestBehavior.AllowGet);

                }
                else
                {
                    return Json("0", JsonRequestBehavior.AllowGet);
                }
            }




        }

        [HttpPost]
        public PartialViewResult SearchAcademicianDetail(int id)
        {
            var academician = academicianRepo.AcademicianById(id);

            return PartialView("AcademicianDetailsPartial", academician);

        }

        public Image Base64ToImage(string base64)
        {
            if (base64 != null)
            {
                try
                {
                    Image image;
                    byte[] imageBytes = Convert.FromBase64String(base64);
                    using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                    {

                        image = Image.FromStream(memoryStream);



                    }
                    return image;
                }
                catch (Exception)
                {
                    return null;
                    throw;
                }
            }
            return null;

        }
    }

}
