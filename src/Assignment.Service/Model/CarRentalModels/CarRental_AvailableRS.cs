using Assignment.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.CarRentalModels
{
    public class CarRental_AvailableRS
    {
        public int? CarId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? ExpectedFare { get; set; }
        public decimal? ExpectedPremiumFare { get; set; }
    }
}
