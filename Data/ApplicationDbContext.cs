using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProvinceCity.Models;

namespace ProvinceCity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Create your own validation/annotations
        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            builder.Entity<City>().Property(m => m.ProvinceCode).IsRequired();
            
            builder.Entity<Province>().ToTable("Provinces");
            builder.Entity<City>().ToTable("Cities");

            builder.Seed();
        }
        // tell entity framework that it needs to know about cities and provinecs
        public DbSet<Province> Provinces {get; set;}
        public DbSet<City> Cities {get; set;}
    }
}
