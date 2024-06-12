using Assignment.Api;
using Assignment.Api.Interfaces.ExpenseInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.Repository.ExpenseRepository
{
    public class ExpenseTrackerExpenseUserRepository : GenericRepository<ExpenseUser> ,IDBExpenseUserRepository
    {
        private readonly RaidenDBContext _dbContext;
        public ExpenseTrackerExpenseUserRepository(RaidenDBContext context) : base(context) {
            _dbContext = context;
        }

        public async Task<bool> AddUser(ExpenseUser user) {
            try {
                await AddAsync(user);
                return true;
            }catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> AuthenticateUser(string email, string password) {
            var user = await _dbContext.ExpenseUsers.Where(u => u.Email == email && u.Password == password).FirstOrDefaultAsync();
            if (user == null)
            {
                return false;
            }
            return true;
        }

        public async Task<ExpenseUser> GetUserByEmail(string email) { 
            var user = await _dbContext.ExpenseUsers.Where(u => u.Email == email).FirstOrDefaultAsync();
            return user;
        }

        public async Task<ExpenseUser> GetUserByCode(string code)
        {
            var user = await _dbContext.ExpenseUsers.Where(u => u.UserCode == code).FirstOrDefaultAsync();
            return user;
        }

        public async Task<bool> CheckValidUser(int id) {
            return await Exists(id);
        }
    }
}
