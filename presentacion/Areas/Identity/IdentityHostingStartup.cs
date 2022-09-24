using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using presentacion.Areas.Identity.Data;

[assembly: HostingStartup(typeof(presentacion.Areas.Identity.IdentityHostingStartup))]
namespace presentacion.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<presentacionIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("presentacionIdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<presentacionIdentityDbContext>();
            });
        }
    }
}