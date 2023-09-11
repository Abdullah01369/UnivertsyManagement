using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivertsyManagement.Models.Concrete;
using UnivertsyManagement.Models;
using UnivertsyManagement.Models.Concrete.Connectiondb;
using UnivertsyManagement.Models.ViewModels;

namespace UnivertsyManagement.Repository
{
    public class AcademicianRepo
    {
        Context context = new Context();

        public Academician AcademicianLogin(AcademicianLoginViewModel academician)
        {
            var academicianControl = context.academicians.Where(x => x.AcademicianMail == academician.AcademicianMail && x.AcademicianPassword == academician.AcademicianPassword).FirstOrDefault();

            return academicianControl;


        }

       public Academician AcademicianByMail(string AcademicianMail)
        {
           var control= context.academicians.Where(x => x.AcademicianMail == AcademicianMail).FirstOrDefault();
            return control;
        }

    }
    //Repo
    


}