using System.Diagnostics;
using System.Web.Mvc;

namespace mvc_demo
{
    public class LogPageRenderedIn : ActionFilterAttribute
    {
        private readonly Stopwatch _stopwatch = new Stopwatch();
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _stopwatch.Start();
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            _stopwatch.Stop();
            filterContext
                .HttpContext
                .Response
                .Write($"<script>console.log(\"page rendered in {_stopwatch.ElapsedMilliseconds}ms \")</script>");
        }
    }
}