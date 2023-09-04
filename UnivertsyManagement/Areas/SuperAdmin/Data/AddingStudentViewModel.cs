using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Areas.SuperAdmin.Data
{
    public class AddingStudentViewModel
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string E_Mail { get; set; }
        public int GenderID { get; set; }
        public int DepartmentID { get; set; }
        public int SinifID { get; set; }
        public string Address { get; set; }
        public int CityID { get; set; }
        public DateTime Birthdate { get; set; }
        public string TC { get; set; }
        public int Degree { get; set; }
        public HttpPostedFileBase  Image { get; set; }

    }
}