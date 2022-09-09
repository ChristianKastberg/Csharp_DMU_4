using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson01.Controllers
{
    public class FormHandlerController : Controller
    {
        // GET: FormHandler
        public ActionResult Index()
        {
            return View();
        }
        
        // POST: FormHandler
        [HttpPost]
        public ActionResult Index(FormCollection formCollection) {
            ViewBag.Firstname = formCollection["Firstname"];
            ViewBag.Lastname = formCollection["Lastname"];
            return View();
        }

    }

}


