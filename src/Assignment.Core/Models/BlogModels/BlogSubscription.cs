using System;
using System.Collections.Generic;

namespace Assignment.Api.Models.BlogModels;

public class BlogSubscription
{
    public int SubscriptionId { get; set; }

    public string Role { get; set; }

    public string SubscriptionType { get; set; }

    public int SubscriptionLimit { get; set; }
}
