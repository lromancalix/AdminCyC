using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO = DtoCyC;
using BLL = cycBLL;
using Newtonsoft.Json;

namespace AdminCyC.Controllers
{
    public class LoginController : Controller
    {
    
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
                  
       

        [HttpGet]
        //[ValidateAntiForgeryToken]
        public JsonResult LoginUser(string userDataLogin) {
            int idUsurario = 0;
            DTO.Login.dtoLoginUsuario userLogin =
               JsonConvert.DeserializeObject<DTO.Login.dtoLoginUsuario>(userDataLogin);
            //DTO.Login.dtoLoginUsuario userLogin = new DTO.Login.dtoLoginUsuario() { usuario = usuario, contrasena = contrasena };
            var x = BLL.clsUsuario._TraerTodosLosUsuarios();
            
            DTO.dtoRespuesta _Respuesta;
            if (ModelState.IsValid) 
            {
                idUsurario = BLL.Login.UserLogin(userLogin);

                if (idUsurario > 0)
                {
                    Helpers.SessionHelper.AddUserToSession(Convert.ToString(idUsurario));
                    _Respuesta = new DTO.dtoRespuesta ("Login", "Usuario encontrado", DTO.TipoRespuesta.exito);
                }
                else {
                    _Respuesta = new DTO.dtoRespuesta("Login", "Datos incorrectos", DTO.TipoRespuesta.error);
                }

            }
            else {
                _Respuesta = new DTO.dtoRespuesta("Login", "Datos incorrectos", DTO.TipoRespuesta.error);
            }

            return Json(_Respuesta,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult RedirectToIndexHome()
        {
            return RedirectToAction("Index", "Home");
        }


    }
}
