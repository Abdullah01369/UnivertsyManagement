using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Areas.SuperAdmin.Data
{
    public class AcademicianSearchViewModel
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TC { get; set; }

        public string Gender { get; set; }
      

       

        public string  Title { get; set; }

        public bool IsActive { get; set; }

        public string AcademicianMail { get; set; }
        public string Birthdate { get; set; }

        public string ImageString { get; set; }

        
        public string Department { get; set; }

     
    }
}