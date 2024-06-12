using Assignment.Api.Interfaces.CarRentalInterfaces;
using Assignment.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.Repository.CarRentalRepository
{
    public class CarRental_CustomerRepository : IDBCarRental_Customer
    {
        private readonly RaidenDBContext _dbContext;

        public CarRental_CustomerRepository(RaidenDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CarRentalCustomer> GetCustomerById(int customerId)
        {
            return await _dbContext.CarRentalCustomers.FirstOrDefaultAsync(c => c.CustomerId == customerId);
        }

        public async Task<CarRentalCustomer> CreateCustomerProfile(CarRentalCustomer customer)
        {
            //customer.CustomerId = 5;
            _dbContext.CarRentalCustomers.Add(customer);
            await _dbContext.SaveChangesAsync();
            return customer;
        }

        public async Task<CarRentalCustomer> UpdateCustomerInformation(CarRentalCustomer customer)
        {
            var toBeUpdated = await _dbContext.CarRentalCustomers.FirstOrDefaultAsync(x => x.CustomerId == customer.CustomerId);
            if (toBeUpdated == null)
            {
                return null;
            }

            toBeUpdated.FirstName = customer.FirstName;
            toBeUpdated.LastName = customer.LastName;
            toBeUpdated.Email = customer.Email;
            toBeUpdated.Phone = customer.Phone;
            toBeUpdated.Address = customer.Address;
            toBeUpdated.IsPremiumCustomer = customer.IsPremiumCustomer;
            toBeUpdated.MembershipExpiration = customer.MembershipExpiration;

            _dbContext.Update(toBeUpdated);
            await _dbContext.SaveChangesAsync();
            return toBeUpdated;
        }
        public async Task<CarRentalCustomer> GetUserByEmailAsync(string email)
        {
            return await _dbContext.CarRentalCustomers.FirstOrDefaultAsync(u => u.Email.Equals(email));
        }
    }
}
