using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminCyC.Tags;

namespace AdminCyC.Controllers
{
    public class SolicitudController : Controller
    {
        // GET: Solicitud
        [Autenticado]
        public ActionResult IndexSolicitud()
        {
            return View();
        }

        public ActionResult Cliente()
        {
            return View();
        }

        public ActionResult Conyugue()
        {
            return View();
        }

        public ActionResult Aval()
        {
            return View();
        }

        public ActionResult Referencias()
        {
            return View();
        }


    }
}