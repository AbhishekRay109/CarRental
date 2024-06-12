using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.CarRentalModels
{
    public class CarRentalCustomerRS
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public bool? IsPremiumCustomer { get; set; }

        public DateTime? MembershipExpiration { get; set; }
    }
}
