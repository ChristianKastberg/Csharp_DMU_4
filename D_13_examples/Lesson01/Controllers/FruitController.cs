using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson01.Controllers
{
    public class FruitController : Controller
    {
        // GET: Fruit
        public ActionResult Index()
        {
            string[] fruits = new string[] { "Apple", "Orange", "Pear", "Banana", "Plum","coconauts" };
            ViewBag.Fruits = fruits;

            return View();
        }

        public ActionResult MyShoppingBag()
        {
            return View();               
        }
    }
}


