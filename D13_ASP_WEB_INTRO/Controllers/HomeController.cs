using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace D13_ASP_WEB_INTRO.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
           

            ViewBag.name = "Bobby Axelrod";
            ViewBag.age = "47";
            ViewBag.birthday = DateTime.Today;
            return View();
        }
    }
}