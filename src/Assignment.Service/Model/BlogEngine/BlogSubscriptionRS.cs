using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.BlogEngine
{
    public class BlogSubscriptionRS
    {
        public string Role { get; set; }

        public string SubscriptionType { get; set; }

        public int SubscriptionLimit { get; set; }
    }
}
