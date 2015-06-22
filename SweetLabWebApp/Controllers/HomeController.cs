using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweetLabWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Productos()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Nosotros()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Contacto()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}