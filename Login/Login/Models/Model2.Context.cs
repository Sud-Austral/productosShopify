﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class listaProductosEntities1 : DbContext
    {
        public listaProductosEntities1()
            : base("name=listaProductosEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<D_Data> D_Data { get; set; }
        public virtual DbSet<D_INVESTIGACION> D_INVESTIGACION { get; set; }
        public virtual DbSet<D_PRIORIZACION> D_PRIORIZACION { get; set; }
        public virtual DbSet<D_PRODUCTO> D_PRODUCTO { get; set; }
        public virtual DbSet<D_SHOPIFY> D_SHOPIFY { get; set; }
    }
}
