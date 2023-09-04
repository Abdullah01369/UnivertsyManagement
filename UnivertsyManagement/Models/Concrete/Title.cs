using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Models.Concrete
{
    public class Title
    {
        [Key]
        public int TitleId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Academician> Academicians { get; set; } = new HashSet<Academician>();
    }
}