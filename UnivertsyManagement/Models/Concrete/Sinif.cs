using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Models.Concrete
{
    public class Sinif
    {
        [Key]
        public int SinifID { get; set; }
        public string Level { get; set; }

        public virtual ICollection<Student> Students { get; set; } 
        public virtual ICollection<Lesson> Lessons { get; set; } 
    }
}