using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Boga's .NET Application.";
            ViewBag.Message = "I'm glad that this worked.";
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is a sample application.";
            ViewBag.Message = "If it works, then i edited the exact files.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact sunil.boga@ggktech.com for any information regarding this app.";

            return View();
        }
    }
}
