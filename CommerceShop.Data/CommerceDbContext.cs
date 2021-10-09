using CommerceShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Data
{
   public class CommerceDbContext : DbContext
    {
        public CommerceDbContext(DbContextOptions<CommerceDbContext> options) : base(options)
        {
        }

        public DbSet<CargoCompany> CargoCompanies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Bill> Bills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasOne(p => p.Role)
                .WithMany(b => b.Users);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Categories)
                .WithMany(b => b.Products);

            modelBuilder.Entity<Customer>()
                .HasMany(o => o.Orders)
                .WithOne(c => c.FKCustomer);

            modelBuilder.Entity<Customer>()
                 .HasMany(o => o.Complaints)
                 .WithOne(c => c.Customer);

            modelBuilder.Entity<Order>()
                 .HasMany(o => o.OrderItems)
                 .WithOne(c => c.FKOrder)
                 .HasForeignKey(o => o.FKOrderId);

            modelBuilder.Entity<OrderItem>()
                 .HasMany(o => o.Complaints)
                 .WithOne(c => c.FKOrderItem)
                 .HasForeignKey(c=> c.FKOrderItemId);


        }

    }
}
