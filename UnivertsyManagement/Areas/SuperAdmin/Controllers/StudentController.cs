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
    public class StudentController : Controller
    {
        StudentRepo studentRepo = new StudentRepo();
        public ActionResult Index()
        {
            return View();
        }

        // veri atarken viewmodel kullan
        public ActionResult AddStudent()
        {
            StudentAddViewModel studentAddViewModel = new StudentAddViewModel();

            studentAddViewModel.City = studentRepo.CityList();
            studentAddViewModel.Genders = studentRepo.GenderList();
            studentAddViewModel.Faculties = studentRepo.FacultyList();
            studentAddViewModel.Sinifs = studentRepo.SinifList();

            return View(studentAddViewModel);
        }

        [HttpGet]
        public JsonResult DepartmentListByFacultyId(int facultyId)
        {
            var list = studentRepo.DepartmentsListByFacultyId(facultyId);

            var departmentViewModels = list.Select(d => new DepartmentViewModel
            {
                DepartmentID = d.DepartmentID,
                DepartmentName = d.NameDepartment,

            }).ToList();

            return Json(departmentViewModels, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult StudentAdd(AddingStudentViewModel student)
        {

            byte[] fileData = new byte[student.Image.ContentLength];

            student.Image.InputStream.Read(fileData, 0, student.Image.ContentLength);

            string base64String = Convert.ToBase64String(fileData);

            var studentmodel = new Student
            {
                Address = student.Address,
                DepartmentID = student.DepartmentID,
                TC = student.TC,
                E_Mail = student.E_Mail,
                Surname = student.Surname,
                SinifID = student.SinifID,
                Password = student.Password,
                CityID = student.CityID,
                Birthdate = student.Birthdate,
                PhotoBase64Text = base64String,
                Name = student.Name,
                Degree = student.Degree,
                GenderID = student.GenderID,



            };

            var val = studentRepo.AddStudent(studentmodel);
            return Json(val);
        }


        public ActionResult SearchStudent()
        {
            var faclist = studentRepo.FacultyList();

            return View(faclist);
        }

        [HttpGet]
        public JsonResult SearchStudentWithParameters(StudentSearchModel searchModel)
        {
            if (!string.IsNullOrEmpty(searchModel.StudentNum))
            {
                List<StudentListViewModel> studentListViewModels = new List<StudentListViewModel>();
                var num = studentRepo.FindStudentWithNo(searchModel.StudentNum);
                if (num != null)
                {
                    Image image;
                    byte[] imageBytes = Convert.FromBase64String(num.PhotoBase64Text);
                    using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                    {

                        image = Image.FromStream(memoryStream);



                    }

                    var model = new StudentListViewModel
                    {
                        Address = num.Address,
                        Birthdate = num.Birthdate,
                        CityName = num.City.CityName,
                        Degree = num.Degree,
                        DepartmentName = num.Department.NameDepartment,
                        E_Mail = num.E_Mail,
                        GANO = num.GANO,
                        Gender = num.Gender.Code,
                        Graduation_Status = num.Graduation_Status,
                        IsActive = num.IsActive,
                        Name = num.Name,
                        Photo = image,
                        SinifLevel = num.Sinif.Level,
                        Surname = num.Surname,
                        TC = num.TC,
                        Student_No = num.Student_No


                    };
                    studentListViewModels.Add(model);
                    return Json(studentListViewModels, JsonRequestBehavior.AllowGet);
                }

                else
                {
                    return Json("-1", JsonRequestBehavior.AllowGet);
                }

            }

            else
            {
                if (!string.IsNullOrEmpty(searchModel.DepartmentID.ToString()))
                {
                    var list = studentRepo.FindStudentWithdDep(searchModel.DepartmentID);
                    if (list != null)
                    {
                        var ListViewModel = list.Select(d => new StudentListViewModel
                        {
                            Student_No = d.Student_No,
                            TC = d.TC,
                            Address = d.Address,
                            CityName = d.City.CityName,
                            Birthdate = d.Birthdate,
                            Degree = d.Degree,
                            DepartmentName = d.Department.NameDepartment,
                            E_Mail = d.E_Mail,
                            GANO = d.GANO,
                            Gender = d.Gender.Code,
                            Graduation_Status = d.Graduation_Status,
                            IsActive = d.IsActive,
                            Name = d.Name,
                            SinifLevel = d.Sinif.Level,
                            Surname = d.Surname,
                            Photo = Base64ToImage(d.PhotoBase64Text)








                        }).ToList();

                        return Json(ListViewModel, JsonRequestBehavior.AllowGet);

                    }
                    return Json("0", JsonRequestBehavior.AllowGet);
                }
                else
                {
                    var listbyfact = studentRepo.FindStudentWithFaculty(searchModel.FacultyID);
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

        }

        [HttpPost]
        public PartialViewResult SearchStudentDetail(string StudentNum)
        {
            var student = studentRepo.FindStudentWithNo(StudentNum);

            return PartialView("PartialStudentDetail",student);

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