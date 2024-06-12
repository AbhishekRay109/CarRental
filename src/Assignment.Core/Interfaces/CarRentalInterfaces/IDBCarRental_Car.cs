using Assignment.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.CarRentalInterfaces
{
    public interface IDBCarRental_Car
    {
        public Task<IEnumerable<CarRentalCar>> GetAllCars();
        public Task<CarRentalCar> GetCarById(int carId);
        public Task<CarRentalCar> AddCar(CarRentalCar car);
        public Task<CarRentalCar> UpdateCar(CarRentalCar car);
        public Task<bool> DeleteCar(int carId);

    }
}
