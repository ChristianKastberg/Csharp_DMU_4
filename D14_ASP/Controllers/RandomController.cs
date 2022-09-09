using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace D14_ASP.Controllers
{
    public class RandomController : Controller
    {
        // GET: Random
        public ActionResult Index()
        {
            Random rnd = new Random();
            int i = rnd.Next(1, 7);

            ViewBag.i = i;
            return View();
        }
    }
}