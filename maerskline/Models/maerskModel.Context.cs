﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace maerskline.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class maerskDB : DbContext
    {
        public maerskDB()
            : base("name=maerskDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<Cargo> Cargoes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Shippment> Shippments { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
    }
}
