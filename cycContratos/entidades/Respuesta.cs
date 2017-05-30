using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace cycContratos.entidades
{
    [DataContract]
    public class Respuesta
    {
        [DataMember]
        public int idRespuesta { get; set; }
        [DataMember]
        public string descripcionRespuesta { get; set; }
        [DataMember]
        public bool isError { get; set; }

    }
}
