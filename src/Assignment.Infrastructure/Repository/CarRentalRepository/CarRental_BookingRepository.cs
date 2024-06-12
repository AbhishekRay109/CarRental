using Assignment.Api.Interfaces.CarRentalInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.Repository.CarRentalRepository
{
    public class CarRental_BookingRepository : IDBCarRental_Booking
    {

        private readonly RaidenDBContext _dbContext;
        public CarRental_BookingRepository(RaidenDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CarRentalBooking> CreateBookingRepo(CarRentalBooking bookingRequest, decimal? premiumExpectedFare, decimal? expectedFare)
        {
            var carRequested = await _dbContext.CarRentalCustomers.FirstOrDefaultAsync(x => x.CustomerId == bookingRequest.CustomerId);
            if(carRequested == null) 
            {
                throw new ArgumentException("Customer Details not found");
            }
            
            if (carRequested.IsPremiumCustomer == true)
            {
                bookingRequest.TotalCost = premiumExpectedFare;
            }
            else
            {
                bookingRequest.TotalCost = expectedFare;
            }
            _dbContext.CarRentalBookings.Add(bookingRequest);
            await _dbContext.SaveChangesAsync();
            return bookingRequest;
        }
        public async Task IsPremiumCustomer(int? customerId)
        {
            var customerDetails = await _dbContext.CarRentalCustomers.FirstOrDefaultAsync(x => x.CustomerId == customerId);
            if (customerDetails == null)
            {
                throw new ArgumentException("No such customer found");
            }
            if(customerDetails.IsPremiumCustomer == true)
            {
                if (customerDetails.MembershipExpiration < DateTime.Now)
                {
                    customerDetails.IsPremiumCustomer = false;
                    _dbContext.Update(customerDetails);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
        public async Task<bool> CancelBookingRepo(int bookingId)
        {
            var carRequested = await _dbContext.CarRentalBookings.FirstOrDefaultAsync(x => x.BookingId == bookingId && x.Status.Equals("Booked"));
            if (carRequested == null)
            {
                return false;
            }
            carRequested.Status = "Cancelled";
            _dbContext.Update(carRequested);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<CarRentalCar> CheckAvailabilityRepo(DateTime? start, DateTime? end, int? carId)
        {
            var carRequested = await _dbContext.CarRentalCars.FirstOrDefaultAsync(x => x.CarId == carId);
            if (carRequested == null)
            {
                throw new ArgumentException("No such carId found");
            }
            if (carRequested.IsUnderMaintenance == true)
            {
                throw new ArgumentException("Unfortunately the car in not available at the moment, please select a different car");
            }
            var overlappingBookings = await _dbContext.CarRentalBookings
        .AnyAsync(booking => booking.CarId == carId &&
        booking.StartDate < end && booking.EndDate > start && booking.Status.Equals("Booked"));
            if (overlappingBookings)
            {
                throw new ArgumentException("The car is not available for the requested period, please select a different time slot");
            }
            return carRequested;
        }
        public async Task<CarRentalBooking> GetBookingDetails(int bookingId)
        {
            return await _dbContext.CarRentalBookings.FirstOrDefaultAsync(u => u.BookingId == bookingId);
        }
        public async Task<CarRentalCar> CarDetails(int? carId)
        {
            var carDetails = await _dbContext.CarRentalCars.FirstOrDefaultAsync(x => x.CarId == carId);
            return carDetails;
        }
        public async Task<CarRentalCustomer> CustomerDetails(int? customerId)
        {
            var customerDetails = await _dbContext.CarRentalCustomers.FirstOrDefaultAsync(x => x.CustomerId == customerId);
            return customerDetails;
        }
        public async Task<int> AvailableCarsCount(string carModel, string carBrand)
        {
            var availCars = await _dbContext.CarRentalCars
                    .Where(x => x.Model.Equals(carModel) && x.Brand.Equals(carBrand))
                    .ToListAsync();
            return availCars.Count;
        }
    }
}