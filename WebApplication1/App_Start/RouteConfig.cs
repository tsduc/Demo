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

            //Trang xem danh sach sach
            routes.MapRoute(
                name: "listbook",
                url: "tim-sach",
                defaults: new { controller = "Book", action = "List" }
            );

            //Trang xem thong tin 1 quyen sach
            routes.MapRoute(
                name: "Detail of book",
                url: "xem-sach/{sach_id}",
                defaults: new { controller = "Book", action = "Detail" }
            );

            routes.MapRoute(
                name: "My Example",
                url: "{hello}/xin-chao-cac-ban",
                defaults: new { controller = "Home", action = "Contact" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

          
        }
    }
}
