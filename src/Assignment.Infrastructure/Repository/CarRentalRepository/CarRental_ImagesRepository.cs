using Assignment.Api.Interfaces.CarRentalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.Repository.CarRentalRepository
{
    public class CarRental_ImagesRepository : IDBCarRental_Images
    {
        private readonly RaidenDBContext _dbContext;
        public CarRental_ImagesRepository(RaidenDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CarRentalImage> AddImage(CarRentalImage image)
        {
            _dbContext.CarRentalImages.Add(image);
            await _dbContext.SaveChangesAsync();
            return image;
        }
        public CarRentalImage GetImageByCarId(int carId)
        {
            return _dbContext.CarRentalImages.FirstOrDefault(i => i.CarId == carId);
        }
    }
}

