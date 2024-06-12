using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models.QuizGame;

namespace Assignment.Api.Interfaces.QuizGameInterfaces
{
    public interface IDBQuizScoreRepository
    {
        Task<QuizScore> GetScoreDetailsByUserIdAndQuizIdAsync(int userId, int quizId);
        Task<List<QuizScore>> GetLeaderboardAsync();
    }
}