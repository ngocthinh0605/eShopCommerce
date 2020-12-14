using Domain.Entities;
using Domain.UserApplication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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
        public DbSet<Emloyee> Emloyees { set; get; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            builder.Entity<Emloyee>().HasData(
           new Emloyee
           {
               Id = 1,
               Name = "Mary",
               Department = "IT",
               Email = "mary@pragimtech.com"
           },
           new Emloyee
           {
           Id = 2,
           Name = "John",
           Department = "HR",
           Email = "john@pragimtech.com"
       }
   );
        }
    }
}