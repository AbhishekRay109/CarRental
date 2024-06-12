using Assignment.Api.Interfaces.CarRentalInterfaces;
using Assignment.Infrastructure;
using Assignment.Service.Model.CarRentalModels;
using Microsoft.AspNetCore.HttpOverrides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Services.CarRentalServices
{
    public class CarRental_CarService
    {

        private readonly IDBCarRental_Car _carRepo;
        public CarRental_CarService(IDBCarRental_Car _carRepo)
        {
            this._carRepo = _carRepo;
        }

        public async Task<IEnumerable<CarRS>> GetAllCars()
        {
            List<CarRS> allCarResponse = new List<CarRS>();
            var allCars = await _carRepo.GetAllCars();
            foreach (var car in allCars)
            {
                var carEntry = MapCarToCarRS(car);
                allCarResponse.Add(carEntry);
            }
            return allCarResponse;
        }

        public async Task<CarRS> GetCarById(int carId)
        {
            var car = await _carRepo.GetCarById(carId);
            var carEntry = MapCarToCarRS(car);
            return carEntry;
        }

        public async Task<CarRS> AddCar(CarRQ car)
        {
            try
            {
                var carEntry = MapCarRQToCar(car);
                var newCar = await _carRepo.AddCar(carEntry);
                var responseCar = MapCarToCarRS(newCar);
                return responseCar;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<CarRS> UpdateCar(int carId, CarRQ car)
        {
            var updatedCar = MapCarRQToCar(car);
            updatedCar.CarId = carId;
            var newCar = await _carRepo.UpdateCar(updatedCar);
            if (newCar == null)
            {
                throw new ArgumentException("Couldn't add car");
            }
            var responseCar = MapCarToCarRS(newCar);
            return responseCar;
        }

        public async Task<bool> DeleteCar(int carId)
        {
            await _carRepo.DeleteCar(carId);
            return false;
        }
        private static CarRentalCar MapCarRQToCar(CarRQ newrq)
        {
            return new CarRentalCar()
            {
                Brand = newrq.Brand,
                Model = newrq.Model,
                Year = newrq.Year,
                Color = newrq.Color,
                RentalRatePerDay = newrq.RentalRatePerDay,
                LastMaintenanceDate = newrq.LastMaintenanceDate,
                IsAvailable = newrq.IsAvailable,
                IsUnderMaintenance = newrq.IsUnderMaintenance
            };
        }
        private static CarRS MapCarToCarRS(CarRentalCar carrs)
        {
            return new CarRS()
            {
                CarId = carrs.CarId,
                Brand = carrs.Brand,
                Model = carrs.Model,
                Year = carrs.Year,
                Color = carrs.Color,
                RentalRatePerDay = carrs.RentalRatePerDay,
                LastMaintenanceDate = carrs.LastMaintenanceDate,
                IsAvailable = carrs.IsAvailable,
                IsUnderMaintenance = carrs.IsUnderMaintenance
            };
        }
    }
}
