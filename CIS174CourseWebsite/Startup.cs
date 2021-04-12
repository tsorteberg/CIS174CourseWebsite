/***************************************************************
* Name        : Startup.cs
* Author      : Tom Sorteberg
* Created     : 02/14/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Module 4 Topic 5  
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.
***************************************************************/
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using CIS174CourseWebsite.Models;
using CIS174CourseWebsite.Areas.M5T4.Models;
using CIS174CourseWebsite.Areas.M6T3.Models;
using CIS174CourseWebsite.Areas.M8T2.Models;
using CIS174CourseWebsite.Areas.M9T2.Models;
using CIS174CourseWebsite.Areas.M8T2.Models.DataLayer;

namespace CIS174CourseWebsite
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
            services.AddMemoryCache();
            services.AddSession();

            services.AddControllersWithViews().AddNewtonsoftJson();

            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            services.AddDbContext<AssignmentContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SharedContext")));
            services.AddDbContext<StudentContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SharedContext")));
            services.AddDbContext<CountryContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SharedContext")));
            services.AddDbContext<TicketContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SharedContext")));
            services.AddDbContext<RegistrationModelContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SharedContext")));
            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = true;
            });
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                    name: "M4T5paging",
                    areaName: "M4T5",
                    pattern: "M4T5/{controller}/{action}/{id}/page{page}");

                endpoints.MapAreaControllerRoute(
                    name: "M4T5default",
                    areaName: "M4T5",
                    pattern: "M4T5/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                    name: "M5T4default",
                    areaName: "M5T4",
                    pattern: "M5T4/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                    name: "M6T3custom",
                    areaName: "M6T3",
                    pattern: "M6T3/{controller}/{action}/game/{activeGame}/category/{activeCategory}");

                endpoints.MapAreaControllerRoute(
                    name: "M6T3default",
                    areaName: "M6T3",
                    pattern: "M6T3/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                    name: "M8T2default",
                    areaName: "M8T2",
                    pattern: "M8T2/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                    name: "M9T2default",
                    areaName: "M9T2",
                    pattern: "M9T2/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
