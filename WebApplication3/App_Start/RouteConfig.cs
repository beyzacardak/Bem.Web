﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Sinema",
                url: "sinema/tur/{tur}",
                defaults: new { controller = "Sinema", action = "Tur" }
            );

            routes.MapRoute(
                name: "SinemaNeZaman",
                url: "sinema/nezaman/{action}",
                defaults: new { controller = "Sinema" }
            );
            routes.MapRoute(
               name: "SinemaNeZamanAralik",
               url: "sinema/nezaman/{Aralik1}/{Aralik2}",
               defaults: new { controller = "Sinema", action= "Aralik" }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
