using AdminCyC.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminCyC.Controllers
{
    public class HomeController : Controller
    {
        [Autenticado]
        public ActionResult Index()
        {
            return View();
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

        [Autenticado]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            Helpers.SessionHelper.DestroyUserSession();
            return RedirectToAction("Index", "Home");
        }
    }
}