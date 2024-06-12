using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Service.Model.CarRentalModels
{
    public class CarRental_ImageRQ
    {
        [Required(ErrorMessage = "Image is required")]
        [DataType(DataType.Upload)]
        [Display(Name = "Image File")]
        public IFormFile Image { get; set; }

        [Required(ErrorMessage = "Car ID is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a valid car ID")]
        public int CarId { get; set; }
    }
}
