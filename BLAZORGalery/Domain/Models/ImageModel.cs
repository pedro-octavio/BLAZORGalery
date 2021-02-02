using System;

namespace BLAZORGalery.Domain.Models
{
    public class ImageModel
    {
        public ImageModel(string id, string imageSRC, DateTime createDate)
        {
            Id = id;
            ImageSRC = imageSRC;
            CreateDate = createDate;
        }

        public ImageModel(string imageSRC)
        {
            Id = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 10);
            ImageSRC = imageSRC;
            CreateDate = DateTime.Now;
        }

        public string Id { get; set; }
        public string ImageSRC { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
