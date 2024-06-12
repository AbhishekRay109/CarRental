using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.CarRentalModels
{
    public class CarRS
    {
        public int CarId { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int? Year { get; set; }

        public string Color { get; set; }

        public decimal? RentalRatePerDay { get; set; }

        public List<DateTime> IsAvailable { get; set; }

        public DateTime? LastMaintenanceDate { get; set; }

        public bool? IsUnderMaintenance { get; set; }
    }
}
