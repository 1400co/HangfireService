using Hangfire;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


namespace AspNetFrameworkHangfireSample
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        //Approach 1
        //Use this if worker will run on website.
        //private IEnumerable<IDisposable> GetHangfireServers()
        //{
        //    GlobalConfiguration.Configuration
        //        .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
        //        .UseSimpleAssemblyNameTypeSerializer()
        //        .UseRecommendedSerializerSettings()
        //        .UseSqlServerStorage("Server=localhost;Initial Catalog=pruebas;User ID=sa;Password=Pass@Word;Encrypt=True;TrustServerCertificate=True;");

        //    var serverOptions = new BackgroundJobServerOptions
        //    {
        //        WorkerCount = 1
        //    };

        //    yield return new BackgroundJobServer(serverOptions);
        //}

        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Approach 1
            //HangfireStartup.ConfigureHangfire(); // Use this if the hangfire server is located outside of web api.
            //HangfireAspNet.Use(GetHangfireServers); //Use this to create the server on website.
            //// Let's also create a sample background job
            //BackgroundJob.Enqueue(() => Debug.WriteLine("Hello world from Hangfire .net Framework!"));
        }
    }
}
