using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO = DtoCyC;
namespace cycBLL
{
   public class Login
    {
        public static int UserLogin(DTO.Login.dtoLoginUsuario usuario) {
          
            return (usuario.usuario == "lroman" && usuario.contrasena == "roman") ? 1 : 0;
        }
    }
}
