using BLAZORGalery.Data.Interfaces;
using BLAZORGalery.Domain.Interfaces;
using BLAZORGalery.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLAZORGalery.Domain.Services
{
    public class ImageService : IImageService
    {
        public ImageService(IImageRepository imageRepository)
        {
            this.imageRepository = imageRepository;
        }

        private readonly IImageRepository imageRepository;

        public async Task<IEnumerable<ImageModel>> GetAllAsync(DateTime? createDate)
        {
            return await imageRepository.GetAllAsync(createDate);
        }

        public async Task AddAsync(ImageModel image)
        {
            await imageRepository.AddAsync(image);
        }

        public async Task DeleteAsync(string id)
        {
            var image = await imageRepository.GetByIdAsync(id);

            switch (image != null)
            {
                case true:
                    {
                        await imageRepository.DeleteAsync(image);

                        break;
                    }
                case false: throw new Exception("The image doens't exists.");
            }
        }
    }
}
