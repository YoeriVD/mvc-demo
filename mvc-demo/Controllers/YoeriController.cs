using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace mvc_demo.Controllers
{
    public class YoeriController : Controller
    {
        [WithId]
        public ActionResult Index(int id)
        {
            return Content(GetMessage());
        }

        public ActionResult Json()
        {
            var obj = new
            {
                message = GetMessage()
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        [ActionName("sorry")]
        public ActionResult Wadde()
        {
            return HttpNotFound("tis weg");
        }
        
        public ActionResult JS() => JavaScript("alert(\'this is bullshit\');");

        [NonAction]
        public string GetMessage()
        {
            return "OL RAAJT";
        }

        protected override void HandleUnknownAction(string actionName)
        {
            Response.Write($"{actionName} not found!");
        }
    }
}
