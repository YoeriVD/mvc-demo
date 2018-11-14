using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;

namespace mvc_demo.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index(User user)
        {
            if (ModelState.IsValid) return RedirectToAction("Ok");
            return View(user);
        }

        public ActionResult Ok()
        {
            return Content("Ok");
        }

        public ActionResult Story(int amount)
        {
            var enumerable = new User().NeverEndingStory();
            var something = enumerable.Take(amount);
            return Content(string.Join(",", enumerable.Take(amount)));
        }
    }

    public class User : IValidatableObject
    {
        [Required(ErrorMessage = "Uwe naam he man!")]
        public string Name { get; set; }
        public string Location { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(Location == "Brugge") yield return new ValidationResult("GEEN WEST-VLAMINGEN!",new List<string>{nameof(Location)});
        }
        
        public IEnumerable<string> NeverEndingStory()
        {
            var count = 0;
            while (true)
            {
                yield return $"some more info {count++}";
            }
        }
    }
}
