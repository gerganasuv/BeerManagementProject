using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BeerManagement.Data.Models;

namespace BeerManagement.Data
{
    public class BeerManagementDbContext : IdentityDbContext<ApplicationUser>
    {
        public BeerManagementDbContext(DbContextOptions<BeerManagementDbContext> options)
            : base(options)
        {
        }

        public DbSet<Beers> Beers { get; set; }
        public DbSet<Manufactures> Manufactures { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                 .Entity<Orders>()
                 .HasOne(b => b.Beer)
                 .WithMany(ord => ord.Order)
                 .HasForeignKey(ord => ord.BeerId);

            builder
                .Entity<Orders>()
                .HasOne(ord => ord.Customer)
                .WithMany(c => c.Order)
                .HasForeignKey(ord => ord.CustomerId);

            builder
            .Entity<Manufactures>()
            .HasMany(m => m.Beer)
            .WithOne(b => b.Manufacture)
            .HasForeignKey(b => b.ManufactureId);

            builder
                .Entity<Sales>()
                .HasOne(s => s.Order);
                

            base.OnModelCreating(builder);
        }
    }
}