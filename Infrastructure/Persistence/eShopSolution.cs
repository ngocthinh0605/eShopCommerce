using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class eShopSolution : IDesignTimeDbContextFactory<eShopContext>
    {
        public eShopContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionstring = configuration.GetConnectionString("bShopDb");
            var optionsBuilder = new DbContextOptionsBuilder<eShopContext>();
            optionsBuilder.UseSqlServer(connectionstring);

            return new eShopContext(optionsBuilder.Options);


        }
    }
}
