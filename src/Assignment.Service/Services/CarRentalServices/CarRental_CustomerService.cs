using Assignment.Api.Interfaces.CarRentalInterfaces;
using Assignment.Infrastructure;
using Assignment.Service.Model;
using Assignment.Service.Model.CarRentalModels;
using Jose;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;

namespace Assignment.Service.Services.CarRentalServices
{
    public class CarRental_CustomerService
    {
        private readonly IDBCarRental_Customer _customerRepo;

        public CarRental_CustomerService(IDBCarRental_Customer customerRepo)
        {
            _customerRepo = customerRepo;
        }

        public async Task<CarRentalCustomerRS> GetCustomerById(int customerId)
        {
            var customer = await _customerRepo.GetCustomerById(customerId);
            return MapCustomerToCustomerRS(customer);
        }

        public async Task<CarRentalCustomerRS> CreateCustomerProfile(CarRentalCustomerRQ customerDetails)
        {
            var customerEntry = MapCustomerRQToCustomer(customerDetails);
            var newCustomer = await _customerRepo.CreateCustomerProfile(customerEntry);
            return MapCustomerToCustomerRS(newCustomer);
        }

        public async Task<CarRentalCustomerRS> UpdateCustomerInformation(int customerId, CarRentalCustomerRQ customerDetails)
        {
            var updatedCustomer = MapCustomerRQToCustomer(customerDetails);
            updatedCustomer.CustomerId = customerId;

            var updatedCustomerInfo = await _customerRepo.UpdateCustomerInformation(updatedCustomer);
            return MapCustomerToCustomerRS(updatedCustomerInfo);
        }
        private static CarRentalCustomerRS MapCustomerToCustomerRS(CarRentalCustomer customer)
        {
            return new CarRentalCustomerRS()
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                Phone = customer.Phone,
                Address = customer.Address,
                IsPremiumCustomer = customer.IsPremiumCustomer,
                MembershipExpiration = customer.MembershipExpiration,
            };
        }

        private static CarRentalCustomer MapCustomerRQToCustomer(CarRentalCustomerRQ customer)
        {
            return new CarRentalCustomer()
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                Phone = customer.Phone,
                Address = customer.Address,
                IsPremiumCustomer = customer.IsPremiumCustomer,
                MembershipExpiration = customer.MembershipExpiration,
                Password = customer.Password,
            };
        }
        public async Task<string> AuthenticationAsync(AuthRQ authRQ)
        {
            var userInfo = await _customerRepo.GetUserByEmailAsync(authRQ.Email);

            if (userInfo == null || userInfo.Password != authRQ.Password)
            {
                throw new ArgumentException("Invalid Username or Password");
            }
            var accessToken = await GenerateJwtToken(userInfo.Email, userInfo.CustomerId);
            return accessToken;
        }
        public async Task<string> GenerateJwtToken(string email, int customerId)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("Secret")));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>
            {
                 new Claim(JwtRegisteredClaimNames.Sub, Environment.GetEnvironmentVariable("Subject")),
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                 new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString())
            };
            var NullList = new List<Claim>();
            var userInfo = await _customerRepo.GetUserByEmailAsync(email);
            if (userInfo.CustomerId == 1)
            {
                claims.Add(new Claim("permissions", "car" + "::" + "create"));
                claims.Add(new Claim("permissions", "car" + "::" + "edit"));
                claims.Add(new Claim("permissions", "car" + "::" + "delete"));
                claims.Add(new Claim("permissions", "car" + "::" + "view"));
                claims.Add(new Claim("permissions", "image" + "::" + "create"));
                claims.Add(new Claim("permissions", "image" + "::" + "view"));
            }
            claims.Add(new Claim("permissions", "car" + "::" + "view"));
            claims.Add(new Claim("permissions", "image" + "::" + "view"));
            claims.Add(new Claim("permissions", "booking" + "::" + "create"));
            claims.Add(new Claim("permissions", "booking" + "::" + "update"));
            claims.Add(new Claim("customerId", customerId.ToString()));
            claims.Add(new Claim("email", email));
            var token = new JwtSecurityToken(
                Environment.GetEnvironmentVariable("ValidIssuer"),
                Environment.GetEnvironmentVariable("ValidIssuer"),
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials
            );
            var encryptedJwt = EncryptJwt(token);
            return encryptedJwt;
        }
        public static string EncryptJwt(JwtSecurityToken token)
        {
            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            var payloadJson = JsonConvert.SerializeObject(tokenString);
            var certificatePath = Environment.GetEnvironmentVariable("CertificatePath");

            X509Certificate2 certWithPublicKey = new X509Certificate2(certificatePath);
            RSA rsaPublicKey = certWithPublicKey.GetRSAPublicKey();

            string encryptedJwt = JWT.Encode(payloadJson, rsaPublicKey, JweAlgorithm.RSA_OAEP, JweEncryption.A256GCM);

            return encryptedJwt;
        }
    }
}
