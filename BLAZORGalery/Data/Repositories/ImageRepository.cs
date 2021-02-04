using BLAZORGalery.Data.Interfaces;
using BLAZORGalery.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLAZORGalery.Data.Repositories
{
    public class ImageRepository : IImageRepository
    {
        public ImageRepository(ApplicationDataContext applicationDataContext)
        {
            this.applicationDataContext = applicationDataContext;
        }

        private readonly ApplicationDataContext applicationDataContext;

        public async Task<IEnumerable<ImageModel>> GetAllAsync(DateTime? createDate)
        {
            switch (createDate != null)
            {
                case true: return await applicationDataContext.Images.Where(x => x.CreateDate <= createDate).ToListAsync();
                case false: return await applicationDataContext.Images.ToListAsync();
            }
        }

        public async Task<ImageModel> GetByIdAsync(string id)
        {
            var image = await applicationDataContext.Images.FindAsync(id);

            if (image != null)
            {
                applicationDataContext.Entry(image).State = EntityState.Detached;
            }

            return image;
        }

        public async Task AddAsync(ImageModel image)
        {
            await applicationDataContext.Images.AddAsync(image);

            await applicationDataContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(ImageModel image)
        {
            applicationDataContext.Images.Remove(image);

            await applicationDataContext.SaveChangesAsync();
        }
    }
}
