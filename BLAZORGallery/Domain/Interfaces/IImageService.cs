using BLAZORGallery.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLAZORGallery.Domain.Interfaces
{
    public interface IImageService
    {
        Task<IEnumerable<ImageModel>> GetAllAsync(DateTime? createDate);
        Task AddAsync(ImageModel image);
        Task DeleteAsync(string id);
    }
}
