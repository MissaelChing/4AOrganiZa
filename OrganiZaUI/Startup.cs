using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrganiZa.Models;
using OrganiZa.Services;
using OrganiZa.Services.Controladores;
using Microsoft.AspNetCore.Session;
namespace OrganiZaUI
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
            services.AddDbContextPool<AppDBContext>(option => {
                option.UseSqlServer(Configuration.GetConnectionString("EFDbConnection"));

            });
            services.AddDistributedMemoryCache();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(20); // Tiempo de expiración   
            });
            services.AddRazorPages();
            services.AddScoped<AppDBContext>();
            services.AddScoped(typeof(IRepository<>), typeof(SQLRepository<>));
            services.AddScoped<IRepositoryValidar, Validacion>();
            services.AddScoped<IRepositoryRegistroTutor, Tutor>();
            services.AddScoped<IRepositoryRegistroAdmi, Administrador>();
            services.AddScoped<IRepositoryRegistroEscuela, Escuela>();
            services.AddScoped<IRepositoryUsuarios, Usuarios>();
            services.AddScoped<IRepositoryPagos, Pagos>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddRouting(option => {
                option.LowercaseUrls = true;
                option.LowercaseQueryStrings = true;
                option.AppendTrailingSlash = true;
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSession();

          
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
