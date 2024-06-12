using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Service.Model.CarRentalModels
{
    public class CarRental_BookingRQ
    {
        [Required(ErrorMessage = "Car ID is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a valid car ID")]
        public int? CarId { get; set; }

        [Required(ErrorMessage = "Start date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DateGreaterThan("StartDate", ErrorMessage = "End date should be greater than Start date")]
        public DateTime? EndDate { get; set; }
    }

    public class DateGreaterThanAttribute : ValidationAttribute
    {
        private readonly string _comparisonProperty;

        public DateGreaterThanAttribute(string comparisonProperty)
        {
            _comparisonProperty = comparisonProperty;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var propertyInfo = validationContext.ObjectType.GetProperty(_comparisonProperty);
            var comparisonValue = (DateTime?)propertyInfo?.GetValue(validationContext.ObjectInstance);

            if (value is DateTime dt && comparisonValue.HasValue && dt <= comparisonValue)
            {
                return new ValidationResult(ErrorMessage ?? "End date should be greater than Start date");
            }

            return ValidationResult.Success;
        }
    }
}
