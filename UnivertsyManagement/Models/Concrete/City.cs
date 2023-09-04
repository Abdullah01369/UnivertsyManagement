using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Models.Concrete
{

    public class City
    {
        [Key]
        public int CityID { get; set; }
        public string CityName { get; set; }

        public ICollection<Student> Students { get; set; }
    }

}