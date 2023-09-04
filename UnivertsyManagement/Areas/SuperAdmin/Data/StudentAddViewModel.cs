using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivertsyManagement.Models.Concrete;

namespace UnivertsyManagement.Areas.SuperAdmin.Data
{
    public class StudentAddViewModel
    {
        public List<City>  City { get; set; }
        public  List<Faculty> Faculties { get; set; }
        public  List<Department> Departments { get; set; }
        public List<Gender> Genders { get; set; }
        public List<Sinif> Sinifs { get; set; }
    }
}