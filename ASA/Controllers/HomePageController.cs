using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASA.Controllers
{
    public class HomePageController : Controller
    {
        // GET: test
        public ActionResult homepage()
        {
            return View();
        }

        public ActionResult contact()
        {
            return View();
        }

      
    }
}