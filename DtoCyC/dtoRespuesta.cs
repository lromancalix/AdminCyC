using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoCyC
{
    public class dtoRespuesta
    {
        public string respuesta { get; set; }
        public string metodo { get; set; }
        public TipoRespuesta tipoRespuesta { get; set; }

        public dtoRespuesta(string respuesta, string metodo, TipoRespuesta tipo)
        {
            this.respuesta = respuesta;
            this.metodo = metodo;
            this.tipoRespuesta = tipo;
        }

    }

    public enum TipoRespuesta {
        error = 0,
        exito = 1
    }
}
