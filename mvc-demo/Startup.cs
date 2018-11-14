using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using mvc_demo;
using mvc_demo.Controllers;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace mvc_demo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            //AreaRegistration.RegisterAllAreas();
            ModelBinders.Binders.Add(typeof(LoggedInUser), new LoggedInUserBinder());
            // New code:
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //ControllerBuilder.Current.SetControllerFactory(typeof(SjareltjeControllerFactory));
        }
    }
}
