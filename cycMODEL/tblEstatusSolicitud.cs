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
    
    public partial class tblEstatusSolicitud
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEstatusSolicitud()
        {
            this.tblSolicitud = new HashSet<tblSolicitud>();
        }
    
        public int idEstatusSolicitud { get; set; }
        public string estatusSolicitud { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSolicitud> tblSolicitud { get; set; }
    }
}
