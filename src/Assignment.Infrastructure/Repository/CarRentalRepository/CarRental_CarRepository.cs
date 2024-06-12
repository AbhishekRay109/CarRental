using Assignment.Api.Interfaces.CarRentalInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static Assignment.Infrastructure.Repository.CarRentalRepository.CarRental_CarRepository;

namespace Assignment.Infrastructure.Repository.CarRentalRepository
{
    public class CarRental_CarRepository : IDBCarRental_Car
    {

        private readonly RaidenDBContext _dbContext;

        public CarRental_CarRepository(RaidenDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<CarRentalCar>> GetAllCars()
        {
            return await _dbContext.CarRentalCars.ToListAsync();
        }

        public async Task<CarRentalCar> GetCarById(int carId)
        {
            return await _dbContext.CarRentalCars.FirstOrDefaultAsync(c => c.CarId == carId);
        }

        public async Task<CarRentalCar> AddCar(CarRentalCar car)
        {
            _dbContext.CarRentalCars.Add(car);
            await _dbContext.SaveChangesAsync();
            return car;
        }

        public async Task<CarRentalCar> UpdateCar(CarRentalCar car)
        {
            var toBeUpdated = await _dbContext.CarRentalCars.FirstOrDefaultAsync(x => x.CarId == car.CarId);
            if (toBeUpdated == null)
            {
                return null;
            }

            toBeUpdated.Brand = car.Brand;
            toBeUpdated.Model = car.Model;
            toBeUpdated.Year = car.Year;
            toBeUpdated.Color = car.Color;
            toBeUpdated.RentalRatePerDay = car.RentalRatePerDay;
            toBeUpdated.LastMaintenanceDate = car.LastMaintenanceDate;
            toBeUpdated.IsAvailable = car.IsAvailable;
            toBeUpdated.IsUnderMaintenance = car.IsUnderMaintenance;
            _dbContext.Update(toBeUpdated);
            await _dbContext.SaveChangesAsync();
            return toBeUpdated;
        }

        public async Task<bool> DeleteCar(int carId)
        {
            var carToDelete = await _dbContext.CarRentalCars.FirstOrDefaultAsync(c => c.CarId == carId);
            var carPics = await _dbContext.CarRentalImages.Where(x => x.CarId == carId).ToListAsync();
            if (carPics.Any())
            {
                foreach(var car in carPics)
                {
                    _dbContext.CarRentalImages.Remove(car);
                }
            }
            if (carToDelete != null)
            {
                _dbContext.CarRentalCars.Remove(carToDelete);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            else { return false; }
        }
    }
}
