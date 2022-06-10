using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMovies.Models;

namespace MVCMovies.Controllers
{
    public class MovieContextController : Controller
    {
        MoviedbEntities mdb = new MoviedbEntities();
        // GET: MovieContext
        public ActionResult Index()
        {
            return View();
        }
    }
}