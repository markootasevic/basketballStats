﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class basketballStatsEntities : DbContext
    {
        public basketballStatsEntities()
            : base("name=basketballStatsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<PlaysFor> PlaysFors { get; set; }
        public virtual DbSet<Stat> Stats { get; set; }
        public virtual DbSet<StatsItem> StatsItems { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
    }
}
