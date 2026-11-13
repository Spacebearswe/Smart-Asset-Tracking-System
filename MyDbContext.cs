using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Asset_Tracking_System
{
    using Microsoft.EntityFrameworkCore;
    using Smart_Asset_Tracking_System.Models;
    using System.Net.Sockets;
    using System.Reflection.Metadata;

    public class MyDbContext : DbContext
    {
        public DbSet<Asset> Assets { get; set; }

        // Update the connection string with your actual database server name
        private readonly string _connectionString =
            "Server=UpdateThis ;Database=asset_tracking_systemEF;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            //.LogTo(Console.WriteLine); // Enable logging to console for debugging purposes

            // Seed the database with test data if it doesn't exist
            optionsBuilder
            .UseSqlServer(_connectionString)
            .UseSeeding((context, _) => // Synchronous seeding
            {
                var testAsset = context.Set<Asset>().FirstOrDefault(a => a.Brand == "HP" && a.Model == "Elitebook");
                if (testAsset == null)
                {
                    Laptop laptop = new Laptop();
                    laptop.Brand = "HP";
                    laptop.Model = "Elitebook";
                    context.Set<Asset>().Add(laptop);
                }

                testAsset = context.Set<Asset>().FirstOrDefault(a => a.Brand == "Dell" && a.Model == "Latitude");
                if (testAsset == null)
                {
                    Laptop laptop = new Laptop();
                    laptop.Brand = "Dell";
                    laptop.Model = "Latitude";
                    context.Set<Asset>().Add(laptop);
                }

                testAsset = context.Set<Asset>().FirstOrDefault(a => a.Model == "S26");
                if (testAsset == null)
                {
                    Samsung samsung = new Samsung();
                    samsung.Model = "S26";
                    context.Set<Asset>().Add(samsung);
                }
                context.SaveChanges();
            });
        }

        // MyDbContext.cs
        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Entity<Asset>()
                .HasDiscriminator<string>("AssetType")
                .HasValue<Laptop>("Laptop")
                .HasValue<DesktopComputer>("DesktopComputer")
                .HasValue<Samsung>("Samsung")
                .HasValue<IPhone>("IPhone")
                .HasValue<Nokia>("Nokia")
                .HasValue<Tablet>("Tablet");
    }
}
