using Microsoft.EntityFrameworkCore;
using shopme.Models;
using System.Data;

namespace shopme.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>().HasKey(am => new
            {
                am.ProductId,
                am.CustomerId
            });

            modelBuilder.Entity<Order_Details>().HasKey(am => new
            {
                am.ProductId,
                am.OrderId
            });

            modelBuilder.Entity<Cart>().HasOne(m => m.Customer).WithMany(am => am.Carts).HasForeignKey(m => m.CustomerId);
            modelBuilder.Entity<Cart>().HasOne(m => m.Product).WithMany(am => am.Carts).HasForeignKey(m => m.ProductId);

            modelBuilder.Entity<Order_Details>().HasOne(m => m.Product).WithMany(am => am.Orders_Details).HasForeignKey(m => m.ProductId);
            modelBuilder.Entity<Order_Details>().HasOne(m => m.Order).WithMany(am => am.Orders_Details).HasForeignKey(m => m.OrderId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order_Details> Orders_Details { get; set; }
    }
}
