using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.QuizGameInterfaces;
using Assignment.Api.Models.QuizGame;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Infrastructure.Repository.QuizGameRepositories
{
    public class QuizDetailRepository : IDBQuizDetailRepository
    {
        private readonly RaidenDBContext _dbContext;

        public QuizDetailRepository(RaidenDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Quiz>> GetAllQuizDetailsAsync()
        {
            return await _dbContext.Quiz
                .Include(q => q.Level)
                .Include(q => q.Category)
                .ToListAsync();
        }

        public async Task<Quiz> CreateQuizAsync(Quiz quizDetails)
        {

            _dbContext.Quiz.Add(quizDetails);
            await _dbContext.SaveChangesAsync();
            return quizDetails;
        }

        public async Task DeleteQuizAsync(int quizId)
        {
            var quiz = await _dbContext.Quiz.FindAsync(quizId);

            if (quiz == null)
            {
                throw new ArgumentException($"Quiz with ID {quizId} not found.");
            }

            _dbContext.Quiz.Remove(quiz);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> LevelExists(int levelId)
        {
            return await _dbContext.QuizLevels.AnyAsync(l => l.LevelId == levelId);
        }

        public async Task<bool> CategoryExists(int categoryId)
        {
            return await _dbContext.QuizCategories.AnyAsync(c => c.CategoryId == categoryId);
        }
    }
}