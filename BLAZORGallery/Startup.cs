using Blazored.Modal;
using BLAZORGallery.Data;
using BLAZORGallery.Data.Interfaces;
using BLAZORGallery.Data.Repositories;
using BLAZORGallery.Domain.Interfaces;
using BLAZORGallery.Domain.Services;
using BLAZORGallery.IOC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BLAZORGallery
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();

            services.AddServerSideBlazor();

            services.AddDbContext<ApplicationDataContext>(x => x.UseSqlite(Configuration.GetConnectionString("BLAZORGaleryDB")));

            services.AddBlazoredModal();

            ConfigurationIOC.ResolveDependencies(services);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
            else
            {
                app.UseExceptionHandler("/Error");

                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();

                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
