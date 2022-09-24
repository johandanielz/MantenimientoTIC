using System.Reflection;
using System.Buffers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using persistencia;

namespace presentacion
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
           
            services.AddScoped<IRepositorioPersona, RepositorioPersona>();
            services.AddScoped<IRepositorioColor, RepositorioColor>();
            services.AddScoped<IRepositorioOperacion, RepositorioOperacion>();
            services.AddScoped<IRepositorioGrupoRepuesto, RepositorioGrupoRepuesto>();
            services.AddScoped<IRepositorioTipoVehiculo, RepositorioTipoVehiculo>();
            services.AddScoped<IRepositorioRepuesto, RepositorioRepuesto>();
            services.AddScoped<IRepositorioVehiculo, RepositorioVehiculo>();
            services.AddScoped<IRepositorioColor, RepositorioColor>();
            services.AddScoped<IRepositorioEstilo, RepositorioEstilo>();
            services.AddScoped<IRepositorioMarca, RepositorioMarca>();
            services.AddScoped<IRepositorioTipoVehiculo, RepositorioTipoVehiculo>();
            services.AddScoped<IRepositorioTecnico, RepositorioTecnico>();
            services.AddScoped<IRepositorioRevision, RepositorioRevision>();
            services.AddScoped<IRepositorioRevOperaciones, RepositorioRevOperaciones>();
            services.AddScoped<IRepositorioRevRepuestos, RepositorioRevRepuestos>();
            services.AddScoped<IRepositorioEstilo, RepositorioEstilo>();
            services.AddScoped<IRepositorioMarca, RepositorioMarca>();
            services.AddControllersWithViews();

            //Configuracion para la conexion a la bd
            services.AddDbContext<AplicationsContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
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

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
