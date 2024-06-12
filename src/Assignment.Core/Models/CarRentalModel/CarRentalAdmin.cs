using Assignment.Api;
using System;
using System.Collections.Generic;

namespace Assignment.Infrastructure;

public partial class CarRentalAdmin
{
    public int AdminId { get; set; }
    public int? CarId { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public virtual CarRentalCar Car { get; set; }
}
