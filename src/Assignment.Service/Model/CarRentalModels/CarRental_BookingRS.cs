using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.CarRentalModels
{
    public class CarRental_BookingRS
    {
        public int BookingId { get; set; }
        public int? CarId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? TotalCost { get; set; }
        public string Status { get; set; }
        public bool? IsApprovedByAdmin { get; set; }
    }
}
