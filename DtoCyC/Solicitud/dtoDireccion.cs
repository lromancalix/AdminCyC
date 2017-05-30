using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoCyC.Solicitud
{
    public class dtoDireccion
    {
        public int idDireccion { get; set; }
        public dtoEstado Estado { get; set; }
        public dtoMunicipio Municipio { get; set; }
        public dtoColonia idColonia { get; set; }
        public string calle { get; set; }
        public string direccion { get; set; }
        public string codigoPostal { get; set; }
        public string manzana { get; set; }
        public string lote { get; set; }
        public string numeroInterior { get; set; }
        public string numeroExterior { get; set; }
        public string cruzamientos { get; set; }
        public string comentarios { get; set; }
    }
}
