﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SCE
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Index",
                url: "",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Default",
               url: "{action}",
               defaults: new { controller = "Home", action = "Contant", id = UrlParameter.Optional }
           );

            routes.MapRoute(
              name: "Account",
              url: "{controller}/{action}",
              defaults: new { controller = "Account", action = "Index", id = UrlParameter.Optional }
          );

        }
    }
}
