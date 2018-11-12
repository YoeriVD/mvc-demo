using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace mvc_demo
{
    public class ControllerFactory : DefaultControllerFactory
    {
        protected override Type GetControllerType(RequestContext requestContext, string controllerName)
        {
            const string suffix = "Sjareltje";
            var controllerType = GetType().Assembly.GetTypes().Where(t => t.Name.EndsWith(suffix))
                .FirstOrDefault(t => t.Name.StartsWith(controllerName));
            return controllerType;
        }
    }
}