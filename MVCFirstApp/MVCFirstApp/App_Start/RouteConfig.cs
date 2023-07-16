﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCFirstApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "De", 
                url: "Process/{action}/{id}",
                defaults: new { controller = "Process", action = "List", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                "Employee", "Employee/{name}",
                 new { controller = "Employee", action = "Search", name = UrlParameter.Optional }
                );
            routes.MapRoute(
                "Current", "CurrentTime/{name}",
                 new { controller = "CurrentTime", action = "Index", name = UrlParameter.Optional }
                );
            routes.MapRoute(
                "Customer", "Customer/{action}/{id}",
                new { controller = "Customer", action = "Index", id = UrlParameter.Optional }
                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
