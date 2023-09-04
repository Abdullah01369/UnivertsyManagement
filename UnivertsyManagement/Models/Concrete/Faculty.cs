using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace UnivertsyManagement.Models.Concrete
{
    public class Faculty
    {
        [Key]
        public int FacultyId { get; set; }
        public string Faculty_Name { get; set; }
        public string FacultyNum{ get; set; }

        public  ICollection<Department> Departments { get; set; } 
    }

}