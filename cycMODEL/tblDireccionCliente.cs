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
    
    public partial class tblDireccionCliente
    {
        public int idDireccion { get; set; }
        public Nullable<int> idColonia { get; set; }
        public string calle { get; set; }
        public string direccion { get; set; }
        public string codigoPostal { get; set; }
        public string manzana { get; set; }
        public string lote { get; set; }
        public string numeroInterior { get; set; }
        public string numeroExterior { get; set; }
        public string cruzamientos { get; set; }
        public string comentarios { get; set; }
        public Nullable<int> idCliente { get; set; }
    
        public virtual tblCliente tblCliente { get; set; }
    }
}
