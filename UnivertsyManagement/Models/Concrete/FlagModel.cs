using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Models.Concrete
{
    public class FlagModel
    {
        [Key]
        public int FlagModelID { get; set; }
        public string Flag { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }
    }
}