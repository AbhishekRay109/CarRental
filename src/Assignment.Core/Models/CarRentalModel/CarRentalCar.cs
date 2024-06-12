using System;
using System.Collections.Generic;

namespace Assignment.Infrastructure;

public partial class CarRentalCar
{
    public int CarId { get; set; }

    public string Brand { get; set; }

    public string Model { get; set; }

    public int? Year { get; set; }

    public string Color { get; set; }

    public decimal? RentalRatePerDay { get; set; }

    public List<DateTime> IsAvailable { get; set; }

    public DateTime? LastMaintenanceDate { get; set; }

    public string Location { get; set; }

    public bool? IsUnderMaintenance { get; set; }

    public virtual ICollection<CarRentalBooking> CarRentalBookings { get; set; } = new List<CarRentalBooking>();

    public virtual ICollection<CarRentalImage> CarRentalImages { get; set; } = new List<CarRentalImage>();

    public virtual ICollection<CarRentalAdmin> CarAdmin { get; set; } = new List<CarRentalAdmin>();

}
