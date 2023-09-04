using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivertsyManagement.Models.Concrete;

namespace UnivertsyManagement.Models.ViewModels
{
    public class StudentIndexViewModel
    {
        public List<Announcements> Announcements { get; set; }
        public Student Student { get; set; }
    }
}