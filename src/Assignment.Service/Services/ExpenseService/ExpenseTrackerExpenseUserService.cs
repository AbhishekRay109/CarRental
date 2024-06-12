using Assignment.Api;
using Assignment.Api.Interfaces.ExpenseInterfaces;
using Assignment.Service.Model;
using Assignment.Service.Model.ExpenseModel;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Services.ExpenseService
{
    public class ExpenseTrackerExpenseUserService
    {
        private readonly IDBExpenseUserRepository _repository;
        private readonly IDBBudgetLedgerRepository ledgerRepository;
        private readonly ExpenseTrackerSecurity security;
        public ExpenseTrackerExpenseUserService(IDBExpenseUserRepository repo, ExpenseTrackerSecurity security, IDBBudgetLedgerRepository ledger)
        {
            _repository = repo;
            this.security = security;
            this.ledgerRepository = ledger;
        }

        public async Task<ExpenseUser> registerUser(ExpenseTrackerRegisterUserRQ user)
        {
            try
            {
                ExpenseUser newUser = new()
                {
                    Name = user.Name,
                    Email = user.Email,
                    Password = security.Encrypt(user.Password),
                    Phone = user.Phone
                };
                if (await _repository.AddUser(newUser))
                {
                    return newUser;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> UserSignin(ExpenseTrackerUserSigninRQ user)
        {
            try
            {
                var response = await _repository.AuthenticateUser(user.Username, security.Encrypt(user.Password));
                if (!response)
                {
                    throw new UnauthorizedAccessException("Invalid email or password!");
                }
                var ValidUser = await _repository.GetUserByEmail(user.Username);
                var token = GenerateTokenForExpenseTracker(ValidUser.UserCode, ValidUser.Email);
                return token;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string GenerateTokenForExpenseTracker(string UserCode, string email)
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
            claims.Add(new Claim("email", email));
            claims.Add(new Claim("userCode", UserCode));
            var token = new JwtSecurityToken(
                Environment.GetEnvironmentVariable("ValidIssuer"),
                Environment.GetEnvironmentVariable("ValidIssuer"),
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
