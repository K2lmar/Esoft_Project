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
    
    public partial class Esoft_ProjectEntities2 : DbContext
    {
        public Esoft_ProjectEntities2()
            : base("name=Esoft_ProjectEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClientsSet> ClientsSet { get; set; }
        public virtual DbSet<RealEstateSet> RealEstateSet { get; set; }
        public virtual DbSet<RealtorsSet> RealtorsSet { get; set; }
    }
}
