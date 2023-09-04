using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Areas.SuperAdmin.Data
{
    public class StudentSearchModel
    {
        public string StudentNum { get; set; }
        public int DepartmentID { get; set; }
        public int FacultyID { get; set; }
    }
}