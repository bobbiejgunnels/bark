using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.AspNetCore.Routing;

namespace Bark
{

    public class RouteConfig
    {
  

        public static void RegisterRoutes(RouteCollection routes)
        {


            config.Routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );
        }
    }
    

}

