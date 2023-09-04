using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UnivertsyManagement
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");




            routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
              namespaces: new[] { "UnivertsyManagement.Controllers" } // Namespace belirtildi



          );

          //  routes.MapRoute(
          //    name: "SuperAdmin", // Alan adı veya tanım adı
          //    url: "SuperAdmin/{controller}/{action}/{id}",
          //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
          //    namespaces: new[] { "UnivertsyManagement.Areas.Admin.Controllers" } // Alanın kontrolörlerinin namespace'i
          //);
        }
    }
}
