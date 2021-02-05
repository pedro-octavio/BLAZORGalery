using BLAZORGallery.Data.Configurations;
using BLAZORGallery.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BLAZORGallery.Data
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ImagesTable.Configure(modelBuilder);
        }

        public DbSet<ImageModel> Images { get; set; }
    }
}
