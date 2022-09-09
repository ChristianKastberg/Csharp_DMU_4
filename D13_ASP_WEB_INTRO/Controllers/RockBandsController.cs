using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace D13_ASP_WEB_INTRO.Controllers
{
    public class RockBandsController : Controller
    {
        // GET: RockBands
        public ActionResult Index()
        {
            string[] rockband = new string[10];
            rockband[0] = "a";
            rockband[1] = "b";
            rockband[2] = "c";
            rockband[3] = "d";
            rockband[4] = "e";
            rockband[5] = "f";
            rockband[6] = "g";
            rockband[7] = "h";
            rockband[8] = "i";
            rockband[9] = "j";

            ViewBag.RockBands = rockband;
            return View();
        }
    }
}