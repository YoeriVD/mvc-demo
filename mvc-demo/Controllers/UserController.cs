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
        public string Name { get;set; }
        public bool IsAdmin { get; set; }
    }
    public class UserBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var loggedInUser = new LoggedInUser()
            {
                Name = "De Yoeri"
            };
            return loggedInUser;
        }
    }

    public class UserController : Controller
    {
        public ActionResult Index(LoggedInUser user) => Content(user.Name);

        public ActionResult NewUser([Bind(Exclude = nameof(Controllers.NewUser.IsAdmin))]NewUser user)
        {
            return Json(user, JsonRequestBehavior.AllowGet);
        }

    }
}
