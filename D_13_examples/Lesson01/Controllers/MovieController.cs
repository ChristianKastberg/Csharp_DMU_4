using Lesson01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson01.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            ViewData["movie2"] = "One Flew Over the Cuckoo's Nest";
            ViewData["year2"] = 2019;

            ViewBag.Movie = "Forrest Gump";
            ViewBag.Year = 1994;

            return View(new Movie { Title = "Intouchables", Year = 2011 });
        }
    }
}