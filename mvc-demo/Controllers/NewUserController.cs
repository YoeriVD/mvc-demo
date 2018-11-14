using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace mvc_demo.Controllers
{
    public class LoggedInUser
    {
        public string Name { get; set; }
    }
    public class NewUser
    {
        public string Name { get; set; }
        public bool IsAdmin { get; set; }
    }

    public class LoggedInUserBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            return new LoggedInUser()
            {
                Name = "Yoeri!"
            };
        }
    }
    public class NewUserController : Controller
    {
        public ActionResult Index(LoggedInUser currentUser)
        {
            return Json(currentUser, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CreateUser([Bind(Exclude = nameof(NewUser.IsAdmin), Prefix = "x")]NewUser newUser)
        {
            return Json(newUser, JsonRequestBehavior.AllowGet);
        }
    }
}
