using CalisanTakip.BusinessEngine.Contracts;
using CalisanTakip.BusinessEngine.Implementation;
using CalisanTakip.Common.ConstantsModel;
using CalisanTakip.Common.Mappings;
using CalisanTakip.DataAccess.Contracts;
using CalisanTakip.DataAccess.DbContext;
using CalisanTakip.DataAccess.DbModels;
using CalisanTakip.DataAccess.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalisanTakip
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
            services.AddRazorPages();
            services.AddDbContext<CalisanTakipContext>(options => options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));
            //************************************************//
            services.AddAutoMapper(typeof(Mapper));
            //services.AddScoped<IEmployeeLeaveAllocation, EmployeeLeaveAllocationRepository>();
            //services.AddScoped<IEmployeeLeaveRequestRepository, EmployeeLeaveRequestRepository>();
            //services.AddScoped<IEmployeeLeaveTypeRepository, EmployeeLeaveTypeRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IEmployeeLeaveTypeBusinessEngine, EmployeeLeaveTypeBusinessEngine>();
            services.AddScoped<IEmployeeLeaveRequestBusinessEngine, EmployeeLeaveRequestBusinessEngine>();
            services.AddScoped<IEmployeeLeaveAssignBusinessEngine, EmployeeLeaveAssignBusinessEngine>();
            services.AddScoped<IWorkOrderBusinessEngine, WorkOrderBusinessEngine>();    
            services.AddScoped<IEmployeeBusinessEngine, EmployeeBusinessEngine>();
            services.AddDefaultIdentity<Employee>().AddRoles<IdentityRole>().AddEntityFrameworkStores<CalisanTakipContext>();
            services.AddControllersWithViews().AddRazorRuntimeCompilation(); 
            services.AddRazorPages();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(3600);
            });
            services.AddMvc();  
           

            //services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<CalisanTakipContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<Employee> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            SeedData.Seed(userManager, roleManager);
            app.UseAuthentication();
            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
