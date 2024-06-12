using Assignment.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.CarRentalInterfaces
{
    public interface IDBCarRental_Booking
    {
        public Task<CarRentalBooking> CreateBookingRepo(CarRentalBooking bookingRequest, decimal? premiumExpectedFare, decimal? expectedFare);
        public Task<bool> CancelBookingRepo(int bookingId);
        public Task<CarRentalCar> CheckAvailabilityRepo(DateTime? start, DateTime? end, int? carId);
        public Task<CarRentalCar> CarDetails(int? carId);
        public Task<CarRentalBooking> GetBookingDetails(int bookingId);
        public Task<CarRentalCustomer> CustomerDetails(int? customerId);
        public Task<int> AvailableCarsCount(string carModel, string carBrand);
        public Task IsPremiumCustomer(int? customerId);





    }
}
