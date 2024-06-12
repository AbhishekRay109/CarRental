using Assignment.Infrastructure;
using Assignment.Service.Model.CarRentalModels;
using Assignment.Service.Services;
using Assignment.Service.Services.CarRentalServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.IdentityModel.Tokens.Jwt;

namespace Assignment.Api.Controllers
{
    /// <summary>
    /// Controller responsible for managing car rental bookings.
    /// </summary>
    [ApiController]
    [Route("api/bookings")]
    public class CarRental_BookingController : ControllerBase
    {
        private readonly CarRental_BookingService _bookingService;
        private readonly AuthService _auth;
        /// <summary>
        /// Constructor injecting the booking service.
        /// </summary>
        public CarRental_BookingController(CarRental_BookingService bookingService, AuthService auth)
        {
            _bookingService = bookingService;
            _auth = auth;
        }
        /// <summary>
        /// Create a new car rental booking.
        /// </summary>
        /// <param name="bookingRequest">Car rental booking request data.</param>
        /// <returns>Result of the booking creation.</returns>
        [CustomAuthorize("carRentalCustomer")]
        [HttpPost]
        public async Task<IActionResult> CreateBooking([FromBody] CarRental_BookingRQ bookingRequest)
        {
            try
            {
                var emaiAndCustomerId = await CheckParams();
                var bookingResult = await _bookingService.CreateBooking(bookingRequest, emaiAndCustomerId);
                return Ok(bookingResult);
            }
            catch(ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        /// <summary>
        /// Cancel a specific car rental booking.
        /// </summary>
        /// <param name="bookingId">ID of the booking to be canceled.</param>
        /// <returns>Result of the cancellation process.</returns>
        [CustomAuthorize("carRentalCustomer")]
        [HttpPut("{bookingId}/cancel")]
        public async Task<IActionResult> CancelBooking(int bookingId)
        {
            try
            {
                var cancelResult = await _bookingService.CancelBooking(bookingId);
                if (cancelResult)
                {
                    return Ok($"Booking with ID {bookingId} has been cancelled.");
                }
                return NotFound($"Booking with ID {bookingId} not found.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Check the availability of a car for a specific date range.
        /// </summary>
        /// <param name="carId">ID of the car to check availability for.</param>
        /// <param name="start">Start date of the date range.</param>
        /// <param name="end">End date of the date range.</param>
        /// <returns>Information about the car's availability.</returns>
        [HttpGet("availability")]
        public async Task<IActionResult> CheckAvailability([FromQuery] int carId, [FromQuery] DateTime start, [FromQuery] DateTime end)
        {
            try
            {
                var availability = await _bookingService.CheckAvailability(start, end, carId);
                return Ok(availability);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("generateInvoice/{bookingId}")]
        public async Task<IActionResult> GenerateInvoice(int bookingId)
        {
            try
            {
                var invoicePdf = await _bookingService.GenerateInvoicePdf(bookingId);
                return File(invoicePdf, "application/pdf", "Invoice.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to generate invoice PDF: {ex.Message}");
            }
        }

        private async Task<string[]> CheckParams()
        {
            try
            {
                
                string JwtToken = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
                var handler = new JwtSecurityTokenHandler();
                var decryptedToken = await _auth.DecryptJwt(JwtToken);
                var tokens = handler.ReadJwtToken(decryptedToken);
                var claims = tokens.Claims;
                var userCode = claims.FirstOrDefault(c => c.Type == "customerId")?.Value;
                var email = claims.FirstOrDefault(c => c.Type == "email")?.Value;
                return new string[] { userCode, email};
            }
            catch (Exception)
            {
                throw new Exception("unable to read the token, we are working on it........");
            }
        }
    }
}