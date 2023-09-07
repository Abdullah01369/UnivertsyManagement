using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Models.Concrete
{
    public class Gender
    {
        [Key]
        public int GenderID { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Academician> Academicians { get; set; }

    }
}