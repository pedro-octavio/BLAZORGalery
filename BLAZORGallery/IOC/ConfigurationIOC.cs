using BLAZORGallery.Data.Interfaces;
using BLAZORGallery.Data.Repositories;
using BLAZORGallery.Domain.Interfaces;
using BLAZORGallery.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BLAZORGallery.IOC
{
    public static class ConfigurationIOC
    {
        public static void ResolveDependencies(IServiceCollection services)
        {
            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<IImageRepository, ImageRepository>();
        }
    }
}
