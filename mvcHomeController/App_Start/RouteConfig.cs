using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mvcHomeController
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                "NumInfo",
               "Home/NumInfo/{myDouble}",
               new { controller = "Home", action = "NumInfo", myDouble = UrlParameter.Optional }
           );

            routes.MapRoute(
                 "StringInfo",
                "Home/StringInfo/{mystring}",
                new { controller = "Home", action = "StringInfo", mystring = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
