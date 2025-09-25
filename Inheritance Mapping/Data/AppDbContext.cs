using Inheritance_Mapping.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Mapping.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Guest> Guests { get; set; } //get all guest // vip and  most  Frequent 
        public DbSet<VIPGuest> VIPGuests { get; set; }

        public DbSet<FrequentGuest> FrequentGuests { get; set;  }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Server=(localdb)\\MSSQLLocalDB;Database=TPHDatabase;Trusted_Connection=True;TrustServerCertificate=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppContext).Assembly);
        }
    }
}
