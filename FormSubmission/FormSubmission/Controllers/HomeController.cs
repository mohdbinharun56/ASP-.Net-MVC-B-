using FormSubmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        //before form submission
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Student());
        }
        // after form submission
        [HttpPost]
        public ActionResult Index(Student s) 
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Contact");
            }
            return View(s);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}