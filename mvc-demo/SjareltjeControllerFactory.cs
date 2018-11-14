using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace mvc_demo
{
    public class SjareltjeControllerFactory : DefaultControllerFactory
    {
        protected override Type GetControllerType(RequestContext requestContext, string controllerName)
        {
            var controllerType = this.GetType()
                .Assembly
                .GetTypes()
                .Where(t => t.Name.EndsWith("Sjareltje"))
                .FirstOrDefault(t => t.Name.ToLowerInvariant().StartsWith(controllerName));
            return controllerType;
        }
    }
}
