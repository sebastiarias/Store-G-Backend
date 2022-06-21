using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using StoregApp.Domain.Entities;

namespace StoregApp.Infrastructure.Persistence
{
    public partial class StoreGContext : DbContext
    {
        public StoreGContext()
        {
        }

        public StoreGContext(DbContextOptions<StoreGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ARIAS-NITRO-5;Database=StoreG;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory);

                entity.Property(e => e.IdCategory)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_category");

                entity.Property(e => e.NameCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Name_category");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);

                entity.Property(e => e.IdCustomer)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_customer");

                entity.Property(e => e.BillingAddres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Billing_addres");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailCustomer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Email_customer");

                entity.Property(e => e.FullNameCustomer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Full_name_customer");

                entity.Property(e => e.PasswordCustomer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Password_customer");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.Property(e => e.IdOrder)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_order");

                entity.Property(e => e.IdCustomer).HasColumnName("Id_customer");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Order_date");

                entity.Property(e => e.OrderEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Order_email");

                entity.Property(e => e.OrderStatus).HasColumnName("Order_status");

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Shipping_address");

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdCustomer)
                    .HasConstraintName("FK_Orders_Customers");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.IdDetail);

                entity.Property(e => e.IdDetail)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_detail");

                entity.Property(e => e.IdOrder).HasColumnName("Id_order");

                entity.Property(e => e.IdProduct).HasColumnName("Id_product");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("price");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.IdOrder)
                    .HasConstraintName("FK_OrderDetails_Orders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.IdProduct)
                    .HasConstraintName("FK_OrderDetails_Products");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct);

                entity.Property(e => e.IdProduct)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Product");

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_day");

                entity.Property(e => e.IdCategory).HasColumnName("Id_category");

                entity.Property(e => e.NameProduct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Name_product");

                entity.Property(e => e.PriceProduct)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Price_product");

                entity.Property(e => e.SkuProduct).HasColumnName("Sku_Product");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("FK_Products_Categories");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
