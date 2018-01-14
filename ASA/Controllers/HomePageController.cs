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
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Book()
        {
            return View();
        }

        public ActionResult Resources()
        {
            return View();
        }

        public ActionResult Routine()
        {
            return View();
        }

        public ActionResult Software()
        {
            return View();
        }
        public ActionResult Assignment()
        {
            return View();
        }

        public ActionResult PrevQues()
        {
            return View();
        }
        public ActionResult Teacher()
        {
            return View();
        }

        public ActionResult TeacherFile()
        {
            return View();
        }
        public ActionResult TeacherBlog()
        {
            return View();
        }

        public ActionResult Post()
        {
            return View();
        }
        public ActionResult qaforum()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult homepage(Student s)
        {
            if (ModelState.IsValid)
            {
                using (ASADatabaseEntities3 dc = new ASADatabaseEntities3())
                {
                    dc.Students.Add(s);
                    dc.SaveChanges();
                    ModelState.Clear();
                    s = null;
                    ViewBag.Message = "Successfully Registration Done";
                }
            }
            return View(s);
        }

        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult homepage(Teacher t)
        {
            if (ModelState.IsValid)
            {
                using (ASADatabaseEntities3 dc = new ASADatabaseEntities3())
                {
                    dc.Teachers.Add(t);
                    dc.SaveChanges();
                    ModelState.Clear();
                    t = null;
                    ViewBag.Message = "Successfully Registration Done";
                }
            }
            return View(t);
        }*/
    }
}
