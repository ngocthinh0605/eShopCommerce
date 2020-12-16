using Domain.Entities;
using Domain.UserApplication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection;

namespace Infrastructure.Persistence
{
    public class eShopContext : IdentityDbContext<ApplicationUser>
    {
        public eShopContext(DbContextOptions<eShopContext> options) :base(options)
        {

        }
        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Categories { set; get; }

        public DbSet<Cart> Carts { set; get; }

        public DbSet<Order> Orders { set; get; }
        
        public DbSet<OrderDetail> OrderDetails { set; get; }

        public DbSet<Transaction> Transactions { set; get; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach (var foreignKey in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

            builder.Entity<OrderDetail>().HasKey(c => new {c.OrderId,c.ProductId});
          
        }
    }
}