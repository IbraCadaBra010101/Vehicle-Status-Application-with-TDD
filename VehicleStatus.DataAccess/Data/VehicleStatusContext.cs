using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleStatus.Core.Domain;

namespace VehicleStatus.DataAccess.Data
{
    public class VehicleStatusContext : DbContext
    {
        public VehicleStatusContext(DbContextOptions<VehicleStatusContext> options) : base(options)
        {
        }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<TransportationCompany> TransportationCompany { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasData(
              new Vehicle { Id = 1, Description = "Desk 1" },
              new Vehicle { Id = 2, Description = "Desk 2" }
            );
            modelBuilder.Entity<TransportationCompany>().HasData(
           new Vehicle { Id = 1, Description = "Desk 1" },
           new Vehicle { Id = 2, Description = "Desk 2" }
         );
        }
    }
}
