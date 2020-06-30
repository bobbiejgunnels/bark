using System.Web.Http;

namespace Bark
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/ {controller} "
                );
            
        }
        //protected void Application_Start()    
        //{

        //    GlobalConfiguration.Configure(config =>
        //    {

        //        config.MapHttpAttributeRoutes();

        //        config.Routes.MapHttpRoute(

        //        name: "DefaultApi",
        //        routeTemplate: "api/{controller}/{id}",
        //        defaults: new { id = RouteParameter.Optional }
        //        );
        //    });
        //}

        //public static void Register(HttpConfiguration config)
        //{
            //Web API configuration and services
        //});
            //Web API routes
    }
}
