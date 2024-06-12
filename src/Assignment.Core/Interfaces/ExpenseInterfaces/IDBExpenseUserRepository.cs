using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.ExpenseInterfaces
{
    public interface IDBExpenseUserRepository
    {
        public Task<bool> AddUser(ExpenseUser user);
        public Task<bool> AuthenticateUser(string email, string password);
        public Task<ExpenseUser> GetUserByEmail(string email);
        public Task<bool> CheckValidUser(int id);
        public Task<ExpenseUser> GetUserByCode(string code);
    }
}
