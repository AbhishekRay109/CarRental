using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Service.Model.CarRentalModels
{
    public class CarRQ
    {
        [Required(ErrorMessage = "Brand is required")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Model is required")]
        public string Model { get; set; }

        [Range(1900, int.MaxValue, ErrorMessage = "Please enter a valid year")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Color is required")]
        public string Color { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Rental rate per day must be a positive number")]
        public decimal? RentalRatePerDay { get; set; }

        public List<DateTime> IsAvailable { get; set; }

        [DataType(DataType.Date)]
        public DateTime? LastMaintenanceDate { get; set; } = DateTime.Now.Date;

        public bool? IsUnderMaintenance { get; set; }
    }
}
