﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbCyCEntities : DbContext
    {
        public dbCyCEntities()
            : base("name=dbCyCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblPermiso> tblPermiso { get; set; }
        public virtual DbSet<tblPermisoDenegadoPorRol> tblPermisoDenegadoPorRol { get; set; }
        public virtual DbSet<tblRol> tblRol { get; set; }
        public virtual DbSet<tblConyugue> tblConyugue { get; set; }
        public virtual DbSet<tblEmpleo> tblEmpleo { get; set; }
        public virtual DbSet<tblEstatusDocumento> tblEstatusDocumento { get; set; }
        public virtual DbSet<tblEstatusSolicitud> tblEstatusSolicitud { get; set; }
        public virtual DbSet<tblReferencia> tblReferencia { get; set; }
        public virtual DbSet<tblSolicitud> tblSolicitud { get; set; }
        public virtual DbSet<tblTipoDocumento> tblTipoDocumento { get; set; }
        public virtual DbSet<tblDireccionAval> tblDireccionAval { get; set; }
        public virtual DbSet<tblDireccionCliente> tblDireccionCliente { get; set; }
        public virtual DbSet<tblDireccionReferencia> tblDireccionReferencia { get; set; }
        public virtual DbSet<tblRelSolicitudDocumento> tblRelSolicitudDocumento { get; set; }
        public virtual DbSet<tblRelUsuarioRol> tblRelUsuarioRol { get; set; }
        public virtual DbSet<tblUsuario> tblUsuario { get; set; }
        public virtual DbSet<tblAval> tblAval { get; set; }
        public virtual DbSet<tblCliente> tblCliente { get; set; }
    }
}
