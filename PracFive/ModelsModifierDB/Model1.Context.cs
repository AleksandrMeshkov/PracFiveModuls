﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracFive.ModelsModifierDB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Security_AgencyEntities : DbContext
    {
        public Security_AgencyEntities()
            : base("name=Security_AgencyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Contracts> Contracts { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Objects> Objects { get; set; }
        public virtual DbSet<Patrols> Patrols { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}