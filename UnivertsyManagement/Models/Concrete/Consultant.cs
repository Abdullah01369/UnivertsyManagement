using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Models.Concrete
{
    public class Consultant
    {
        [Key]
        public int ConsultantID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TC { get; set; }

        public int DepartmentID  { get; set; }
        public virtual Department Department  { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }

}