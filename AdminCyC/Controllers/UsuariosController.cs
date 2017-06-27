using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminCyC.Tags;
using DTO = DtoCyC;
using Newtonsoft.Json;

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
        [HttpGet]
        public JsonResult UpdateCreateUser(string usuario)
        {
            DTO.Usuario.dtoUsuario usuarioDTO =
                JsonConvert.DeserializeObject<DTO.Usuario.dtoUsuario>(usuario);

            return Json(usuarioDTO, JsonRequestBehavior.AllowGet);
        }

    }
}