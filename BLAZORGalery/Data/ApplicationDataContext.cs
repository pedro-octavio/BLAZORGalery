using BLAZORGalery.Data.Configurations;
using BLAZORGalery.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BLAZORGalery.Data
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
