using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace mvc_demo.Controllers
{
    public class NewEntity : IValidatableObject
    {
        [Required] public string Name { get; set; }
        [Required] public string Location { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(Location == "Brugge") yield return new ValidationResult("West-Vlamingen niet welkom!");
        }
    }

    public class ValidationController : Controller
    {
        public ActionResult Index(NewEntity entity)
        {
            if (!ModelState.IsValid)
                return Content("Bad request  mboy");
            return Json(entity, JsonRequestBehavior.AllowGet);
        }
        public ActionResult MyView(NewEntity entity)
        {
            if(!ModelState.IsValid) ModelState.AddModelError(string.Empty, "Fix errors please");
            return View(entity);
        }
    }
}