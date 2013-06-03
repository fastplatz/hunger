using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hunger.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public class GMap
        {
            public object[] Locations { get; set; }
            public string Description { get; set; }
        }

        [HttpGet]
        public ActionResult Map()
        {
            ViewBag.Message = "TODO: put the google map with pins here.";

            return View();
        }

        [HttpPost]
        public ActionResult Map(GMap gmap)
        {
            Session["MapData"] = gmap;
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
