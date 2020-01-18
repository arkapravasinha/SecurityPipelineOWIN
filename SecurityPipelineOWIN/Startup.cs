using Owin;
using SecurityPipelineOWIN.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SecurityPipelineOWIN
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var configuration = new HttpConfiguration();

            configuration.Routes.MapHttpRoute(
                "default",
                "api/{Controller}");

            //adding filter globally
          //  configuration.Filters.Add(new AuthenticationFilterAttribute());

            //wiring up Middleware
            appBuilder.Use(typeof(TestMiddleware));

            //wiring up WEB API
            appBuilder.UseWebApi(configuration);
        }
    }
}