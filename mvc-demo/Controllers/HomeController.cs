using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_demo.Controllers
{
    public class HomeController : Controller
    {
        [RenderTime]
        public ActionResult Index()
        {
            ViewBag.Dummy = "Controller";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
    public class HomeSjareltje : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Dummy = "Sjareltje";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your sjareltje description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}