using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoCyC.Solicitud
{
    class dtoAval
    {
        public int idAval { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string rfc { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string sexo { get; set; }
        public string lada { get; set; }
        public string celular { get; set; }
        public string correo { get; set; }

        public dtoEmpleo Empleo { get; set; }
        public List<dtoDireccion> Direccion { get; set; }


    }
}
