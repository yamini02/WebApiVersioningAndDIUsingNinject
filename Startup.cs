using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Web.Http;
using Microsoft.Web.Http.Versioning;
using Owin;

[assembly: OwinStartup(typeof(WebApiVersioningWithNinject.Startup))]

namespace WebApiVersioningWithNinject
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888

            var configuration = new HttpConfiguration();
            var httpServer = new HttpServer(configuration);

            //configuration.AddApiVersioning(o =>
            //{
            //    o.ReportApiVersions = true;
            //    o.AssumeDefaultVersionWhenUnspecified = true;
            //    o.DefaultApiVersion = new ApiVersion(2, 0);
            //    o.ApiVersionReader = new HeaderApiVersionReader("api-version");
            //    o.ApiVersionSelector = new CurrentImplementationApiVersionSelector(o);
            //}
            //);
            //configuration.MapHttpAttributeRoutes();
            app.UseWebApi(httpServer);
        }
    }
}
