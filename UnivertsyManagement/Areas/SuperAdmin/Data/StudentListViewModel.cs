using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Areas.SuperAdmin.Data
{
    public class StudentListViewModel
    {
    
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Student_No { get; set; }
        
        public string CityName { get; set; }
        public string Gender  { get; set; }
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        public string E_Mail { get; set; }
        public string TC { get; set; }
        public bool Graduation_Status { get; set; }
        public bool IsActive { get; set; }
        public float GANO { get; set; }
        public Image Photo { get; set; }
        public int Degree { get; set; }
        public string SinifLevel { get; set; }
        public string DepartmentName { get; set; }

    }
}