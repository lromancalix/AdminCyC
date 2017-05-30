//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cycMODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCliente()
        {
            this.tblRelDocumentoCliente = new HashSet<tblRelDocumentoCliente>();
        }
    
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string rfc { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public string sexo { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<int> idSolicitud { get; set; }
        public Nullable<int> idEmpleo { get; set; }
        public Nullable<int> idEstadoCivil { get; set; }
        public Nullable<int> idDireccion { get; set; }
        public string celular { get; set; }
        public string lada { get; set; }
        public string correo { get; set; }
    
        public virtual tblDireccion tblDireccion { get; set; }
        public virtual tblEmpleo tblEmpleo { get; set; }
        public virtual tblSolicitud tblSolicitud { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRelDocumentoCliente> tblRelDocumentoCliente { get; set; }
    }
}
