using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminCyC.Tags;

namespace AdminCyC.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        [Autenticado]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult vpDetalleUsuario() {
            return View();
        }
    }
}