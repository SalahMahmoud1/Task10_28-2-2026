using Microsoft.EntityFrameworkCore;
using SalesDB.Model;
using System;
using System.Collections.Generic;
using System.Text;
namespace SalesDB.Data
{
    internal class ApplicationSalesDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Coustomer> Coustomers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string ConStr = "Data Source=.;initial Catalog=SalesDatabase;Integrated Security=True;";
            ConStr += "Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;";
            optionsBuilder.UseSqlServer(ConStr);
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

          // Product
          modelBuilder.Entity<Product>()
              .Property(p => p.Name)
              .HasMaxLength(50)
              .IsUnicode(true);
            //----------Add Default Value----------
            modelBuilder.Entity<Product>()
            .Property(p => p.Description)
            .HasDefaultValue("No Description");
            // Coustomer
            modelBuilder.Entity<Coustomer>()
            .Property(c => c.Name)
            .HasMaxLength(100)
            .IsUnicode(true);
           
            
        modelBuilder.Entity<Coustomer>()
            .Property(c => c.Email)
            .HasMaxLength(80)
            .IsUnicode(false);
            

        // Store
        modelBuilder.Entity<Store>()
            .Property(s => s.Name)
            .HasMaxLength(80)
            .IsUnicode(true);

            // Add Default value to Column Date In Sale Model
            modelBuilder.Entity<Sale>()
                .Property(s => s.Date)
                .HasDefaultValueSql("GETDATE()");
        }

    }
    }
