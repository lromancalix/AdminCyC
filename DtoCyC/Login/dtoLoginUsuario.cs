using System.ComponentModel.DataAnnotations;

namespace DtoCyC.Login
{
    public class dtoLoginUsuario : dtoError
    {
        [Required(ErrorMessage ="El usuario es requerido.") ]
        public string usuario { get; set; }
        [Required(ErrorMessage ="La contraseña es requerida.")]
        [MinLength(5)]
        public string contrasena { get; set; }
    }
}
