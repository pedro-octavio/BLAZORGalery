using BLAZORGalery.Domain.Interfaces;
using BLAZORGalery.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLAZORGalery.Domain.Services
{
    public class ImageService : IImageService
    {
        public async Task<IEnumerable<ImageModel>> GetAllAsync(DateTime? createDate)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(ImageModel image)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
