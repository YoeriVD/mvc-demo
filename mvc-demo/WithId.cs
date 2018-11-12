using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace mvc_demo
{
    public class WithId : ActionMethodSelectorAttribute
    {
        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            return methodInfo.GetParameters().Select(p => p.Name).Contains("id");
        }
    }
}