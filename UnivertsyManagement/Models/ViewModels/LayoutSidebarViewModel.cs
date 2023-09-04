using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Models.ViewModels
{
    public class LayoutSidebarViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string StudentNo { get; set; }
        public string PhotoBase64 { get; set; }
        public float Gano { get; set; }
        public string Depatment { get; set; }
    }
}