using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnivertsyManagement.Models.Concrete
{
    public class Announcements
    {
        [Key]
        public int AnnouncementsID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime AddingDate { get; set; }
        public bool IsActive { get; set; }
    }
}