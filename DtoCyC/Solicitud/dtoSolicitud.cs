using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoCyC.Solicitud
{
    public class DtoSolicitud
    {
        [Key]
        public int idSolicitud { get; set; }
        public string folio { get; set; }
        public int idEstatus { get; set; }
        public int idSubestatus { get; set; }


    }
}
