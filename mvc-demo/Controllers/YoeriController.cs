using System.Web.Mvc;

namespace mvc_demo.Controllers
{
    
    public class YoeriController : Controller
    {
        
        public ActionResult Index()
        {
            return Content(GetMessage());
        }

        [ActionName("json")]
        public ActionResult IndexAlsJson()
        {
            return Json(new {message = GetMessage()}, JsonRequestBehavior.AllowGet);
        }

        [NonAction]
        public string GetMessage() => "Tzal wel zijn!";


        public ActionResult TisWeg()
        {
            return HttpNotFound("niet gevonden");
        }

        protected override void HandleUnknownAction(string actionName)
        {
            Response.Write($"{actionName} besta nie he jong!");
        }
    }
    public class YoeriSjareltje : Controller
    {
        public ActionResult Index()
        {
            return Content(GetMessage());
        }
        [NonAction]
        public string GetMessage() => "Tzal wel zijn, sjareltje!";
    }
}