using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Visit> Visits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>()
                .HasMany(x => x.Visits)
                .WithRequired(x => x.Client)
                .WillCascadeOnDelete();
        }
    }
}
