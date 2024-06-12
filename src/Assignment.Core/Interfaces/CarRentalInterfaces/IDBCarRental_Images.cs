using Assignment.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.CarRentalInterfaces
{
    public interface IDBCarRental_Images
    {
        public Task<CarRentalImage> AddImage(CarRentalImage image);
        public CarRentalImage GetImageByCarId(int carId);

    }
}
