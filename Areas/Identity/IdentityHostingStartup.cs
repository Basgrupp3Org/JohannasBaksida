using System;
using JohannasBaksida.Areas.Identity.Data;
using JohannasBaksida.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(JohannasBaksida.Areas.Identity.IdentityHostingStartup))]
namespace JohannasBaksida.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<JohannasBaksidaContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("JohannasBaksidaContextConnection")));

                services.AddDefaultIdentity<JohannasBaksidaUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<JohannasBaksidaContext>();
            });
        }
    }
}