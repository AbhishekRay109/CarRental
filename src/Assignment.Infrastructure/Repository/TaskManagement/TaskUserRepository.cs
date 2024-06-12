using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.TaskManagement;
using Assignment.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Infrastructure.Repository.TaskUser
{
    public class TaskUserRepository : IDBTaskUserRepository
    {
        private readonly RaidenDBContext _dbContext;

        public TaskUserRepository(RaidenDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TaskUsers> GetUserByUsernameAsync(string userEmail)
        {
            return await _dbContext.TaskUsers.FirstOrDefaultAsync(u => u.Email == userEmail);
        }

        public async Task<TaskUsers> CreateUserAsync(TaskUsers user)
        {
            _dbContext.TaskUsers.Add(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }
        public async Task<TaskUsers> AuthTaskUserAsync(string email)
        {
            var user1 = await _dbContext.TaskUsers.FirstOrDefaultAsync(e=>e.Email==email);
            return user1;
        }
    }
}
