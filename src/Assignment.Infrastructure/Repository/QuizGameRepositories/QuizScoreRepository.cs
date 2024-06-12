using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.QuizGameInterfaces;
using Assignment.Api.Models.QuizGame;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Infrastructure.Repository.QuizGameRepositories
{
    public class QuizScoreRepository : IDBQuizScoreRepository
    {
        private readonly RaidenDBContext _dbContext;

        public QuizScoreRepository(RaidenDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<QuizScore> GetScoreDetailsByUserIdAndQuizIdAsync(int userId, int quizId)
        {
            var quizScore = await _dbContext.QuizScores
                .Include(qs => qs.User)
                .Include(qs => qs.Quiz)
                .Include(qs => qs.AnsweredQuestions)
                .Where(s => s.UserId == userId && s.QuizId == quizId)
                .FirstOrDefaultAsync();

            return quizScore;
        }


        public async Task<List<QuizScore>> GetLeaderboardAsync()
        {
            var leaderboard = await _dbContext.QuizScores
                .Include(qs => qs.User) 
                .Include(qs => qs.Quiz)
                .OrderByDescending(qs => qs.Score)
                .Take(10) 
                .ToListAsync();

            return leaderboard;
        }
    }
}