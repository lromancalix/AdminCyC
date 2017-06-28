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
    }
}