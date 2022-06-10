using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetStudentLocation()
        {
            ViewBag.StudentLocation = "Hyderabad";
            ViewBag.StudentName = "Pavitrakshari";
            return View();
        }

        public IActionResult GetStudentPhoneNo()
        {
            return View();
        }
    }
}
