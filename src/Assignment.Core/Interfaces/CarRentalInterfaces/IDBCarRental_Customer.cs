using Assignment.Api.Models;
using Assignment.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.CarRentalInterfaces
{
    public interface IDBCarRental_Customer
    {
        public Task<CarRentalCustomer> GetCustomerById(int customerId);
        public Task<CarRentalCustomer> CreateCustomerProfile(CarRentalCustomer customer);
        public Task<CarRentalCustomer> UpdateCustomerInformation(CarRentalCustomer customer);
        public Task<CarRentalCustomer> GetUserByEmailAsync(string email);


    }
}
