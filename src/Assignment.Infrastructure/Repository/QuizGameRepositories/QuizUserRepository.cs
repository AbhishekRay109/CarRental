using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces;
using Assignment.Api.Models.QuizGame;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Infrastructure.Repository.QuizGame
{
    public class QuizUserRepository : IDBQuizUserRepository
    {
        private readonly RaidenDBContext _dbContext;
        public QuizUserRepository(RaidenDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public bool EmailExists(string email)
        {
            return _dbContext.QuizUsers.Any(e => e.Email == email);
        }

        public bool IsValidUser(string email, string password)
        {
            return _dbContext.QuizUsers.Any(e => e.Email == email && e.Password == password);
        }

        public async Task<QuizUser> RegisterUserAsync(QuizUser user)
        {
            _dbContext.QuizUsers.Add(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }

        public async Task<List<QuizUser>> GetAllUsersAsync()
        {
            var users = await _dbContext.QuizUsers.ToListAsync();
            return users;
        }

        public async Task<QuizUser> GetUserByIdAsync(int userId)
        {
            var user = await _dbContext.QuizUsers.FindAsync(userId);
            return user;
        }

        public async Task UpdateUserAsync(QuizUser user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

    }
}