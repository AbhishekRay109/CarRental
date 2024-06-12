using System;
using System.Collections.Generic;

namespace Assignment.Infrastructure;

public partial class CarRentalCustomer
{
    public int CustomerId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string Address { get; set; }

    public bool? IsPremiumCustomer { get; set; }

    public string Password { get; set; }

    public DateTime? MembershipExpiration { get; set; }

    public virtual ICollection<CarRentalBooking> CarRentalBookings { get; set; } = new List<CarRentalBooking>();
}
