using System.Diagnostics;
using System.Web.Mvc;

namespace mvc_demo.Controllers
{
    public class RenderTime : ActionFilterAttribute
    {
        private readonly Stopwatch _stopwatch = new Stopwatch();

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            _stopwatch.Start();
            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            _stopwatch.Stop();
            filterContext.RequestContext.HttpContext.Response.Write(
                $"<script>console.log(\' rendered in {_stopwatch.ElapsedMilliseconds} ms\')</script>");
            base.OnResultExecuted(filterContext);
        }
    }
}