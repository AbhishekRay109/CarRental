using Assignment.Api.Interfaces.CarRentalInterfaces;
using Assignment.Infrastructure;
using Assignment.Infrastructure.Repository;
using Assignment.Service.Model.CarRentalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Services.CarRentalServices
{
    public class CarRental_ImageService
    {

        private readonly IDBCarRental_Images _imageRepository;

        public CarRental_ImageService(IDBCarRental_Images imageRepository)
        {
            _imageRepository = imageRepository; ;
        }

        public async Task<CarRentalImage> SaveImage(CarRental_ImageRQ imageRQ)
        {
            if (imageRQ.Image == null)
            {
                throw new ArgumentException("Image is required.");
            }
            byte[] imageData;
            using (var stream = imageRQ.Image.OpenReadStream())
            {
                using (var memoryStream = new MemoryStream())
                {
                    imageRQ.Image.CopyTo(memoryStream);
                    imageData = memoryStream.ToArray();
                }
            }
            var carImage = new CarRentalImage
            {
                Image = imageData,
                CarId = imageRQ.CarId
            };
            carImage = await _imageRepository.AddImage(carImage);
            return carImage;

        }

        public CarRentalImage GetImageByCarId(int carId)
        {
            return _imageRepository.GetImageByCarId(carId);
        }

    }
}
