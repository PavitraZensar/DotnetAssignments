using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day1.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetFirstname()
        {
            return View();
        }

        public IActionResult GetLastname()
        {
            return View();
        }
    }
}
