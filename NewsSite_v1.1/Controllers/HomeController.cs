using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsSite_v1._1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Documentation()
        {
            ViewBag.Message = "Assignment Description";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Support Contact";

            return View();
        }
    }
}