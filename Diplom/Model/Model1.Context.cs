﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplom.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MolochnikovKursEntities : DbContext
    {
        public MolochnikovKursEntities()
            : base("name=MolochnikovKursEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<App> App { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Levels> Levels { get; set; }
        public virtual DbSet<Online_coach> Online_coach { get; set; }
        public virtual DbSet<Program> Program { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Themes> Themes { get; set; }
        public virtual DbSet<Topics> Topics { get; set; }
    }
}
