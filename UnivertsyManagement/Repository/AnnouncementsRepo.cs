using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnivertsyManagement.Models.Concrete;
using UnivertsyManagement.Models.Concrete.Connectiondb;

namespace UnivertsyManagement.Repository
{
    public class AnnouncementsRepo
    {
        Context context = new Context();

        public List<Announcements> AnnouncementList()
        {
           var anno= context.announcements.Where(x=>x.IsActive==true).OrderByDescending(x=>x.AddingDate).ToList();

            return anno;
        }

    }
}