using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;
using TrainingDbApp.Models;

namespace TrainingDbApp.Data
{
   public class AppDbContext: DbContext

    {

        public AppDbContext()
        {
        }

       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base( options) {  }
        public DbSet<User> Users => Set<User>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<OrderItem> OrderItems => Set<OrderItem>();
        public DbSet<Review> Reviews => Set<Review>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Categories)
                .WithMany(c => c.Products)
                .UsingEntity(j => j.ToTable("ProductCategories"));

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=(localdb)\\MSSQLLocalDB;Database=TrainingDbAppDb;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

    }
}
