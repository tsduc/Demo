using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Trang1",
                url: "trang",
                defaults: new { controller = "New", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "WebApplication1.Controllers" }
            );

            routes.MapRoute(
                name: "Trang2",
                url: "trang_2",
                defaults: new { controller = "New", action = "Index2" },
                namespaces: new[] { "WebApplication1.Controllers" }
            );
        }
    }
}
