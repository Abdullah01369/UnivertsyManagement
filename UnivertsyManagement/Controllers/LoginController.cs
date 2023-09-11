using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using UnivertsyManagement.Models;
using UnivertsyManagement.Models.ViewModels;
using UnivertsyManagement.Repository;

[assembly: OwinStartup(typeof(UnivertsyManagement.Models.StartUp.Startup))]

namespace UnivertsyManagement.Controllers
{

    public class LoginController : Controller
    {
        StudentRepo StudentRepo = new StudentRepo();
        AcademicianRepo AcademicianRepo = new AcademicianRepo();    
        
        private IAuthenticationManager AuthenticationManager
        {
            get { return HttpContext.GetOwinContext().Authentication; }
        }


        public JsonResult LoginStudent(StudentLoginViewModel student)
        {
            var value = StudentRepo.StudentLogin(student);
            if (value == null)
            {
                return Json("0");
            }
            else
            {
               
                var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, value.Student_No),
                 
                    // Diğer iddia türleri...
                }, "ApplicationCookie");

                AuthenticationManager.SignIn(new AuthenticationProperties
                {
                    IsPersistent = false // Kalıcı oturum açma
                }, identity);


                return Json("1");
            }

        }
        public JsonResult LoginAcademician(AcademicianLoginViewModel academician)
        {
            var value = AcademicianRepo.AcademicianLogin(academician);
            if (value == null)
            {
                return Json("0");
            }
            else
            {

                var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, value.AcademicianMail),
                 
                    // Diğer iddia türleri...
                }, "ApplicationCookie");

                AuthenticationManager.SignIn(new AuthenticationProperties
                {
                    IsPersistent = false // Kalıcı oturum açma
                }, identity);


                return Json("1");
            }

        }
    }
}