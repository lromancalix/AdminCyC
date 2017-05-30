using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace cycContratos.entidades
{
    [DataContract]
    public class Rol
    {
        [DataMember]
        public int idRol { get; set; }
        [DataMember]
        public string rol { get; set; }
    }
}
