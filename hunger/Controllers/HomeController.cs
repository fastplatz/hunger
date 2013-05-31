using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hunger.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Map()
        {
            ViewBag.Message = "TODO: put the google map with pins here.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Let's solve world hunger by starting here in Asheville.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact your congressman.";

            return View();
        }
    }
}
