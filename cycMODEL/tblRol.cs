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
    
    public partial class tblRol
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRol()
        {
            this.tblPermisoDenegadoPorRol = new HashSet<tblPermisoDenegadoPorRol>();
            this.tblUsuario = new HashSet<tblUsuario>();
        }
    
        public int idRol { get; set; }
        public string rol { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPermisoDenegadoPorRol> tblPermisoDenegadoPorRol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUsuario> tblUsuario { get; set; }
    }
}
