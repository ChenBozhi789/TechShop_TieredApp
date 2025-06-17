using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public partial class ModelContext : DbContext
    {
        public ModelContext() 
        {

        }

        // Need to understnad
        // Constructor
        public ModelContext(DbContextOptions<ModelContext> options): base(options)
        {

        }

        // Mapping C# business entities to database domain classes
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Desktop> Desktops { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 继承映射（TPH）
            modelBuilder.Entity<Product>()
                .HasDiscriminator<string>("ProductType")
                .HasValue<Laptop>("Laptop")
                .HasValue<Desktop>("Desktop");

            // Brand - Product 一对多
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Brand)
                .WithMany(b => b.Products)
                .HasForeignKey(p => p.BrandID);

            // Product - Order 一对多
            modelBuilder.Entity<Order>()
                .HasOne(o => o.OrderedProduct)
                .WithMany(p => p.Orders)
                .HasForeignKey(o => o.ProductID);

            // Configure Product table field and attributes
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(p => p.Name).IsRequired().HasMaxLength(100);
                entity.Property(p => p.Description).IsRequired().HasMaxLength(500);
                entity.Property(p => p.Price).HasColumnType("decimal(18,2)");
                entity.Property(p => p.ProductImage).IsRequired().HasMaxLength(255);
                entity.Property(p => p.PublishedDate).HasColumnType("datetime");
                entity.Property(p => p.StockQuantity);
                entity.Property(p => p.LastModifiedDate).HasColumnType("datetime");
                entity.Property(p => p.CPU).HasMaxLength(100);
                entity.Property(p => p.GPU).HasMaxLength(100);
                entity.Property(p => p.Memory).HasMaxLength(100);
            });

            // Configure Brand table field and attributes
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(b => b.Name).IsRequired().HasMaxLength(100);
                entity.Property(b => b.Manufacturer).IsRequired().HasMaxLength(100);
                entity.Property(b => b.Country).IsRequired().HasMaxLength(50);
                entity.Property(b => b.Website).IsRequired().HasMaxLength(255);
            });
           
            // Configure Order table field and attributes
            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(o => o.Quantity).IsRequired();
                entity.Property(o => o.Amount).HasColumnType("decimal(10,2)");
                entity.Property(o => o.CustomerName).HasMaxLength(100);
                entity.Property(o => o.Email).HasMaxLength(255);
                entity.Property(o => o.Number);
                entity.Property(o => o.OrderStatus).HasMaxLength(20);
                entity.Property(o => o.TimeStamp).HasColumnType("datetime");
            });
        }
    }
}