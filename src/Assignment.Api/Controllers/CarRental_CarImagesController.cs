using Assignment.Infrastructure;
using Assignment.Service.Model.CarRentalModels;
using Assignment.Service.Services.CarRentalServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Assignment.Api.Controllers
{
    /// <summary>
    /// Controller handling car images in the car rental system.
    /// </summary>
    [ApiController]
    [Route("api/carsImages")]
    public class CarRental_CarImagesController : ControllerBase
    {
        /// <summary>
        /// Service handling image-related operations for cars in the car rental system.
        /// </summary>
        public static CarRental_ImageService _imageService;
        /// <summary>
        /// Constructor for CarRental_CarImagesController injecting CarRental_ImageService.
        /// </summary>
        public CarRental_CarImagesController(CarRental_ImageService imageService)
        {
            _imageService = imageService;
        }
        /// <summary>
        /// Upload an image for a specific car.
        /// </summary>
        /// <param name="imageRQ">Request containing the image to be uploaded.</param>
        [CustomAuthorize("carRentalAdmin")]
        [HttpPost()]
        public async Task<CarRentalImage> ConvertToCarRentalImage([FromForm] CarRental_ImageRQ imageRQ)
        {
            try
            {
                if (imageRQ.Image == null)
                {
                    throw new ArgumentException("Image is required.");
                }
                CarRentalImage reponse = await _imageService.SaveImage(imageRQ);
                return reponse;
            }
            catch(Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// Get images associated with a specific car.
        /// </summary>
        /// <param name="carId">ID of the car to fetch images for.</param>
        [CustomAuthorize("carRentalCustomer")]
        [HttpGet("{carId}")]
        public IActionResult GetImage(int carId)
        {
            try
            {
                var image = _imageService.GetImageByCarId(carId);
                if (image == null)
                {
                    return NotFound("Image not found");
                }
                return File(image.Image, "image/jpeg");
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
    }
}

