using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Custom_Helpers.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult CustomHelp()
        {
            return View();
        }
    }
}