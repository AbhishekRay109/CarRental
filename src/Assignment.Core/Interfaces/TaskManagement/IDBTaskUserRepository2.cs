using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models;

namespace Assignment.Api.Interfaces.TaskManagement
{
    public interface IDBTaskUserRepository
    {
        public Task<TaskUsers> GetUserByUsernameAsync(string username);
        public Task<TaskUsers> CreateUserAsync(TaskUsers user);
        public Task<TaskUsers> AuthTaskUserAsync(string email);
    }
}