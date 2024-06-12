using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models.QuizGame;

namespace Assignment.Api.Interfaces
{
    public interface IDBQuizUserRepository
    {
        bool IsValidUser(string email, string password);
        bool EmailExists(string email);
        Task<QuizUser> RegisterUserAsync(QuizUser user);
        Task<List<QuizUser>> GetAllUsersAsync();
        Task<QuizUser> GetUserByIdAsync(int userId);
        Task UpdateUserAsync(QuizUser user);
    }
}