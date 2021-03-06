﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CA_ATaleOfThreeCalculators
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "UrlCalculator",
                url: "UrlCalculator/{action}/{operand1}/{operand2}",
                defaults: new { controller = "UrlCalculator", action = "Index", operand1 = UrlParameter.Optional, operand2 = UrlParameter.Optional }
            );
        }
    }
}
