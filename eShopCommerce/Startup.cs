using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.Services;
using Domain.Repository;
using Domain.UserApplication;
using Infrastructure.Persistence;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace eShopCommerce
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<eShopContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("bShopDb")));
            services.AddIdentity<ApplicationUser, IdentityRole>(
                options => 
                {
                    options.Password.RequiredLength = 6;
                    options.Password.RequiredUniqueChars = 0;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                })
                .AddEntityFrameworkStores<eShopContext>();

            services.Configure<IdentityOptions>(options =>  
            {
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            });

           services.AddMvc(options =>                                         ///*[AllowAnonymous]*/ cho phep an quyen  an danh
           {                                                                  ///*[AllowAnonymous]*/ cho phep an quyen
               var policy = new AuthorizationPolicyBuilder()                  ///*[AllowAnonymous]*/ cho phep an quyen
                               .RequireAuthenticatedUser()                    ///*[AllowAnonymous]*/ cho phep an quyen
                               .Build();                                      ///*[AllowAnonymous]*/ cho phep an quyen
               options.Filters.Add(new AuthorizeFilter(policy));              ///*[AllowAnonymous]*/ cho phep an quyen
         
           }
           ).AddXmlSerializerFormatters();
            services.AddAuthorization(options =>
            {
               /* options.AddPolicy("DeleteRolePolicy",
                    policy => policy.RequireClaim("Delete Role"));*/

                options.AddPolicy("EditRolePolicy",
                    policy => policy.RequireClaim("Edit Role","true"));


                options.AddPolicy("StaffRolePolicy",
                    policy => policy.RequireRole("Staff"));

                options.AddPolicy("AdminRolePolicy",
                   policy => policy.RequireRole("Admin", "Staff"));


                options.AddPolicy("AllowedCountryPolicy",
                   policy => policy.RequireClaim("Country", "USA", "India", "UK"));
            });

            services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=eShop}/{action=Index}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
