using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models.QuizGame;

namespace Assignment.Api.Interfaces.QuizGameInterfaces
{
    public interface IDBQuizDetailRepository
    {
        Task<IEnumerable<Quiz>> GetAllQuizDetailsAsync();
        Task<Quiz> CreateQuizAsync(Quiz quizDetails);
        Task<bool> CategoryExists(int categoryId);
        Task<bool> LevelExists(int levelId);
        Task DeleteQuizAsync(int quizId);
    }
}