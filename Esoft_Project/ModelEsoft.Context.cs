﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Esoft_Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Esoft_ProjectEntities4 : DbContext
    {
        public Esoft_ProjectEntities4()
            : base("name=Esoft_ProjectEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClientsSet> ClientsSet { get; set; }
        public virtual DbSet<DealSet> DealSet { get; set; }
        public virtual DbSet<DemandSet> DemandSet { get; set; }
        public virtual DbSet<RealEstateSet> RealEstateSet { get; set; }
        public virtual DbSet<RealtorsSet> RealtorsSet { get; set; }
        public virtual DbSet<SupplySet> SupplySet { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
