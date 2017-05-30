using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace cycContratos.entidades
{
    [DataContract]
    public class Usuario : Respuesta
    {
        [DataMember]
        public int idUsuario { get; set; }
        [DataMember]
        public string usuario { get; set; }
        [DataMember]
        public string contrasena { get; set; }
        [DataMember]
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        [DataMember]
        public string apellidoMaterno { get; set; }
        [DataMember]
        public Rol rolDeUsuario { get; set; }

    }
}
