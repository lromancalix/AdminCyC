//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cycMODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblConyugue
    {
        public int idConyugue { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string celular { get; set; }
        public string lada { get; set; }
        public string correo { get; set; }
        public Nullable<int> idSolicitud { get; set; }
        public Nullable<int> idEmpleo { get; set; }
    
        public virtual tblEmpleo tblEmpleo { get; set; }
        public virtual tblSolicitud tblSolicitud { get; set; }
    }
}
