﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApplication11
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class lcdatabaseTestEntities : DbContext
    {
        public lcdatabaseTestEntities()
            : base("name=lcdatabaseTestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<person> people { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Box> Boxes { get; set; }
        public virtual DbSet<collected_contract_items> collected_contract_items { get; set; }
        public virtual DbSet<collected_contracts> collected_contracts { get; set; }
        public virtual DbSet<com_proposal> com_proposal { get; set; }
        public virtual DbSet<company_details> company_details { get; set; }
        public virtual DbSet<contract> contracts { get; set; }
        public virtual DbSet<items_in_boxes> items_in_boxes { get; set; }
        public virtual DbSet<items_in_contract> items_in_contract { get; set; }
        public virtual DbSet<items_in_cp> items_in_cp { get; set; }
        public virtual DbSet<official_letters> official_letters { get; set; }
        public virtual DbSet<orderItem> orderItems { get; set; }
        public virtual DbSet<order> orders { get; set; }
    }
}