using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminCyC.Tags;
using DTO = DtoCyC;
using BLL = cycBLL;
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

        [Autenticado]
        [HttpGet]
        public JsonResult UpdateCreateUser(string usuario)
        {
            DTO.Usuario.dtoUsuario usuarioDTO =
                JsonConvert.DeserializeObject<DTO.Usuario.dtoUsuario>(usuario);
            BLL.clsUsuario._GuardaUsuario(usuarioDTO);
            return Json(usuarioDTO, JsonRequestBehavior.AllowGet);
        }

    }
}