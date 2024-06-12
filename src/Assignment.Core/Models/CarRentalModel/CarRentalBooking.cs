using System;
using System.Collections.Generic;

namespace Assignment.Infrastructure;

public partial class CarRentalBooking
{
    public int BookingId { get; set; }

    public int? CarId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? TotalCost { get; set; }

    public string Status { get; set; }

    public bool? IsApprovedByAdmin { get; set; }

    public virtual CarRentalCar Car { get; set; }

    public virtual CarRentalCustomer Customer { get; set; }
}
