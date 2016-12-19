using HealthDataBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Persistence
{
    class HealthDbContext :DbContext
    {
        public HealthDbContext(): base("HealthDbConnection") { }

        public DbSet<users> Users { get; set; }

        public DbSet<illness> Illness { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
            modelBuilder.Entity<illness>().ToTable("Illness");
        }
        public DbSet<Symptom> symptoms { get; set; }
    }
}
