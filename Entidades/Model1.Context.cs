﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_BibliotecaEntities : DbContext
    {
        public DB_BibliotecaEntities()
            : base("name=DB_BibliotecaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<existencias> existencias { get; set; }
        public virtual DbSet<Libros> Libros { get; set; }
        public virtual DbSet<prestamoDet> prestamoDet { get; set; }
        public virtual DbSet<prestamoEnc> prestamoEnc { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<ventanas> ventanas { get; set; }
        public virtual DbSet<permisosDeRol> permisosDeRol { get; set; }
        public virtual DbSet<permisosAUsuarios> permisosAUsuarios { get; set; }
        public virtual DbSet<rolAsignadoAUsuario> rolAsignadoAUsuario { get; set; }
        public virtual DbSet<Bitacora> Bitacora { get; set; }
    }
}