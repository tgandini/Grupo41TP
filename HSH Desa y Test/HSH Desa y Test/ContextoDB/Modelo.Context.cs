﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HSH_Desa_y_Test.ContextoDB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ContextoEntity : DbContext
    {
        public ContextoEntity()
            : base("name=ContextoEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<foto> fotos { get; set; }
        public virtual DbSet<HotSale> HotSales { get; set; }
        public virtual DbSet<Propiedad> Propiedads { get; set; }
        public virtual DbSet<ReservaDirecta> ReservaDirectas { get; set; }
        public virtual DbSet<subasta> subastas { get; set; }
        public virtual DbSet<tarjeta> tarjetas { get; set; }
        public virtual DbSet<usuario> usuarios { get; set; }
        public virtual DbSet<usuarioParticipaEnSubasta> usuarioParticipaEnSubastas { get; set; }
    }
}
