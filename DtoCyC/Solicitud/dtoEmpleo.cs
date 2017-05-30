using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoCyC.Solicitud
{
    public class dtoEmpleo : dtoDireccion
    {
        public int idEmpleo { get; set; }
        public string nombreEmpresa { get; set; }
        public string departamento { get; set; }
        public string puesto { get; set; }
        public string giroEmpresa { get; set; }
        public string telefono { get; set; }
        public string ext { get; set; }
    }
}
