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
            optionsBuilder.UseSqlServer(connectionString: "Server=(localdb)\\MSSQLLocalDB;Database=TPTDatabase;Trusted_Connection=True;TrustServerCertificate=True;");

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Guest>().ToTable(name: "Guests");
            builder.Entity<VIPGuest>().ToTable(name: "VIPGuests");
            builder.Entity<FrequentGuest>().ToTable(name: "FrequentGuests");
            builder.ApplyConfigurationsFromAssembly(typeof(AppContext).Assembly);
        }
    }
}
