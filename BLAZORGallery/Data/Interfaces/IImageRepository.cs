using BLAZORGallery.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLAZORGallery.Data.Interfaces
{
    public interface IImageRepository
    {
        Task<IEnumerable<ImageModel>> GetAllAsync(DateTime? createDate);
        Task<ImageModel> GetByIdAsync(string id);
        Task AddAsync(ImageModel image);
        Task DeleteAsync(ImageModel image);
    }
}
