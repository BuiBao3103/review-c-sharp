﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnTap2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class qlthietbiEntities : DbContext
    {
        public qlthietbiEntities()
            : base("name=qlthietbiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Donvi> Donvis { get; set; }
        public virtual DbSet<Loaithietbi> Loaithietbis { get; set; }
        public virtual DbSet<Thietbi> Thietbis { get; set; }
    }
}
