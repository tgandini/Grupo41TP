﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
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
