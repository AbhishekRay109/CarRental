using System;
using System.Collections.Generic;

namespace Assignment.Infrastructure;

public partial class CarRentalImage
{
    public int ImageId { get; set; }

    public int? CarId { get; set; }

    public byte[] Image { get; set; }

    public virtual CarRentalCar Car { get; set; }
}
