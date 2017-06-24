using DtoCyC.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DtoCyC.Usuario
{
    public class dtoUsuario
    {
        [Key]
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string fechaCreacion { get; set; }
        public dtoRol idRol { get; set; }
    }
}
