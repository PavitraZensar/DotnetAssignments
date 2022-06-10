using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAY2MVC.Models;

namespace DAY2MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee e = new Employee() { ID = 10, Name = "Pavitrakshari", DOJ = DateTime.Now, Email = "nikitha@gmail.com" };
            return View(e);
        }
    }
}