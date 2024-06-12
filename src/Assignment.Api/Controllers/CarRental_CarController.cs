using Assignment.Infrastructure;
using Assignment.Service.Model.CarRentalModels;
using Assignment.Service.Services.CarRentalServices;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Assignment.Api.Controllers
{
    /// <summary>
    /// Controller handling car-related operations in the car rental system.
    /// </summary>
    [ApiController]
    [Route("carRental/car")]
    public class CarRental_CarController : ControllerBase
    {
        private readonly CarRental_CarService _carService;
        /// <summary>
        /// Constructor for CarRental_CarController injecting CarRental_CarService.
        /// </summary>
        public CarRental_CarController(CarRental_CarService carService)
        {
            _carService = carService;
        }
        /// <summary>
        /// Retrieve all cars available in the car rental system.
        /// </summary>
        [CustomAuthorize("carRentalCustomer")]
        [HttpGet("list")]
        public async Task<IActionResult> GetAllCars()
        {
            var cars = await _carService.GetAllCars();
            return Ok(cars);
        }

        /// <summary>
        /// Retrieve details of a specific car by its ID.
        /// </summary>
        /// <param name="carId">ID of the car to retrieve details for.</param>
        [CustomAuthorize("carRentalCustomer")]
        [HttpGet("{carId}")]
        public async Task<IActionResult> GetCarById(int carId)
        {
            try
            {
                var car = await _carService.GetCarById(carId);
                if (car == null)
                {
                    return NotFound();
                }
                return Ok(car);
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
        /// Add a new car to the car rental system.
        /// </summary>
        /// <param name="carDetails">Details of the car to be added.</param>
        [CustomAuthorize("carRentalAdmin")]
        [HttpPost]
        public async Task<IActionResult> AddCar([FromBody] CarRQ carDetails)
        {
            try
            {
                var createdCar = await _carService.AddCar(carDetails);
                return Ok(createdCar);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }


        /// <summary>
        /// Update details of a specific car.
        /// </summary>
        /// <param name="carId">ID of the car to be updated.</param>
        /// <param name="carDetail">Updated details of the car.</param>
        [CustomAuthorize("carRentalAdmin")]
        [HttpPut("{carId}")]
        public async Task<IActionResult> UpdateCar(int carId, [FromBody] CarRQ carDetail)
        {
            try
            {
                var updatedCar = await _carService.UpdateCar(carId, carDetail);
                return Ok(updatedCar);
            }
            catch(ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Delete a specific car from the car rental system by its ID.
        /// </summary>
        /// <param name="carId">ID of the car to be deleted.</param>
        [CustomAuthorize("carRentalAdmin")]
        [HttpDelete("{carId}")]
        public async Task<IActionResult> DeleteCar(int carId)
        {
            try
            {
                var deletedCar = await _carService.DeleteCar(carId);
                return Ok($"Deleted car details for carId: {carId}");
            }
            catch(ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch(Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
