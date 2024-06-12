using Assignment.Api.Interfaces.CarRentalInterfaces;
using Assignment.Infrastructure;
using Assignment.Service.Model.CarRentalModels;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout;
using Org.BouncyCastle.Tls;
using iText.Layout.Properties;
using System.Diagnostics.Eventing.Reader;

namespace Assignment.Service.Services.CarRentalServices
{
    public class CarRental_BookingService
    {
        private readonly IDBCarRental_Booking _bookingRepository;
        public CarRental_BookingService(IDBCarRental_Booking bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task<CarRental_BookingRS> CreateBooking(CarRental_BookingRQ bookingRequest ,string[] customerId )
        {

            var fare = await CheckAvailability(bookingRequest.StartDate, bookingRequest.EndDate, bookingRequest.CarId);
            var makeBooking = new CarRentalBooking()
            {
                CarId = bookingRequest.CarId,
                CustomerId = Convert.ToInt32(customerId[0]),
                StartDate = bookingRequest.StartDate,
                EndDate = bookingRequest.EndDate, 
                Status = "Booked", 
                IsApprovedByAdmin = true
            };
            await _bookingRepository.IsPremiumCustomer(makeBooking.CustomerId);
            makeBooking = await _bookingRepository.CreateBookingRepo(makeBooking, fare.ExpectedPremiumFare, fare.ExpectedFare);
            var response = new CarRental_BookingRS()
            {
                BookingId = makeBooking.BookingId,
                CarId = makeBooking.CarId,
                CustomerId = makeBooking.CustomerId,
                StartDate = makeBooking.StartDate,
                EndDate = makeBooking.EndDate,
                TotalCost = makeBooking.TotalCost,
                Status = makeBooking.Status,
                IsApprovedByAdmin = makeBooking.IsApprovedByAdmin
            };
            return response;
        }

        public async Task<bool> CancelBooking(int bookingId)
        {
            try
            {
                var makeBooking = await _bookingRepository.CancelBookingRepo(bookingId);
                if (makeBooking)
                {
                    return true;
                }
                throw new ArgumentException("no such booking found");
            }
            catch
            {
                throw;
            }
        }

        public async Task<CarRental_AvailableRS> CheckAvailability(DateTime? start, DateTime? end, int? carId)
        {
            var carDetails = await _bookingRepository.CheckAvailabilityRepo(start, end, carId);
            var hikeRate = await _bookingRepository.AvailableCarsCount(carDetails.Model, carDetails.Brand);
            decimal? hike;
            if (hikeRate > 3)
            {
                hike = 1;
            }
            else if (hikeRate > 2)
            {
                hike = 1.1M;
            }
            else
            {
                hike = 1.2M;
            }
            TimeSpan totalDuration = end.Value - start.Value;
            decimal noOfDays = (decimal)Math.Ceiling(totalDuration.TotalDays);
            decimal? fare = carDetails.RentalRatePerDay * noOfDays * hike;
            decimal? premiumFare = fare * 9 / 10;

            var response = new CarRental_AvailableRS()
            {
                CarId = carId,
                StartDate = start,
                EndDate = end,
                ExpectedFare = fare,
                ExpectedPremiumFare = premiumFare
            };
            return response;
        }
        public async Task<byte[]> GenerateInvoicePdf(int bookingId)
        {
            try
            {
                var invoiceData = await _bookingRepository.GetBookingDetails(bookingId);
                var carDetail = await _bookingRepository.CarDetails(invoiceData.CarId);
                var customerDetail = await _bookingRepository.CustomerDetails(invoiceData.CustomerId);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (PdfWriter writer = new PdfWriter(memoryStream))
                    {
                        using (PdfDocument pdf = new PdfDocument(writer))
                        {
                            iText.Layout.Document document = new(pdf);


                            document.Add(new Paragraph("Booking Details")
                                .SetTextAlignment(TextAlignment.CENTER)
                                .SetBold()
                                .SetFontSize(20));

                            document.Add(new Paragraph("Booking ID: " + invoiceData.BookingId));
                            document.Add(new Paragraph("Car ID: " + invoiceData.CarId));
                            document.Add(new Paragraph("Car Brand: " + carDetail.Brand));
                            document.Add(new Paragraph("Car Color: " + carDetail.Color));
                            document.Add(new Paragraph("Start date: " + invoiceData.StartDate));
                            document.Add(new Paragraph("End date: " + invoiceData.EndDate));
                            document.Add(new Paragraph("Status: " + invoiceData.Status));
                            document.Add(new Paragraph("Total Amount: " + invoiceData.TotalCost));

                            document.Add(new AreaBreak());
                            document.Add(new Paragraph("Customer Details")
                                .SetTextAlignment(TextAlignment.CENTER)
                                .SetBold()
                                .SetFontSize(20));

                            document.Add(new Paragraph("First Name: " + customerDetail.FirstName));
                            document.Add(new Paragraph("Last Name: " + customerDetail.LastName));
                            document.Add(new Paragraph("Email: " + customerDetail.Email));

                            document.Close();
                            return memoryStream.ToArray();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Unable to generate PDF");
            }
        }
    }
}