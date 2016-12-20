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
    /// <summary>
    /// Jaimin Patel
    /// This is the class where the data base data is being pulled through and being manipulated 
    /// in other classes
    /// </summary>
    class HealthDbContext :DbContext
    {
        public HealthDbContext(): base("HealthDbConnection") { }

        public DbSet<users> Users { get; set; }

        public DbSet<illness> Illness { get; set; }
        
        // this code makes sure the entity illness gets connected to illness
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
            modelBuilder.Entity<illness>().ToTable("Illness");
        }
        public DbSet<Symptom> symptoms { get; set; }
    }
}
