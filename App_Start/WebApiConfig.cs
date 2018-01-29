using Microsoft.Web.Http;
using Microsoft.Web.Http.Versioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApiVersioningWithNinject
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var httpServer = new HttpServer(config);
            config.AddApiVersioning(o =>
            {
                o.ReportApiVersions = true;
                o.AssumeDefaultVersionWhenUnspecified = true;
                o.DefaultApiVersion = new ApiVersion(2, 0);
                o.ApiVersionReader = new HeaderApiVersionReader("api-version");
                o.ApiVersionSelector = new CurrentImplementationApiVersionSelector(o);
            }
          );
           // config.MapHttpAttributeRoutes();
           // app.UseWebApi(httpServer);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
