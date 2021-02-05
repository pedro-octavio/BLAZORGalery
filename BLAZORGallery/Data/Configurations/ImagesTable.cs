using BLAZORGallery.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BLAZORGallery.Data.Configurations
{
    internal static class ImagesTable
    {
        internal static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ImageModel>()
                .Property(x => x.Id)
                .HasMaxLength(10)
                .IsRequired();

            modelBuilder.Entity<ImageModel>()
                .Property(x => x.ImageSRC)
                .IsRequired();

            modelBuilder.Entity<ImageModel>()
                .Property(x => x.CreateDate)
                .IsRequired();
        }
    }
}
