using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace UnivertsyManagement.Models.Concrete
{
    public class Department
    {
       
        [Key]
        public int DepartmentID { get; set; }
        public string NameDepartment { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentNum { get; set; }
        public string DepartmentTelNumber { get; set; }

 
        public int? FacultyId { get; set; }

        public virtual Faculty Faculty { get; set; }

        public  ICollection<Academician> Academicians { get; set; }
      
        public  ICollection<Student> Students { get; set; }
        public  ICollection<Lesson> Lessons { get; set; } 
        public  ICollection<Consultant> Consultants { get; set; } 
    }
}