using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Areas.SuperAdmin.Data
{
    public class AcademicianAddingModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string E_Mail { get; set; }
        public int GenderID { get; set; }
        public int DepartmentID { get; set; }
        public string TC { get; set; }
        public int TitleId { get; set; }
        public string BirthDate { get; set; }
        public HttpPostedFileBase Image { get; set; }

    }
}