using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.QuizGameInterfaces;
using Assignment.Api.Models.QuizGame;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Infrastructure.Repository.QuizGameRepositories
{
    public class QuizAnswerRepository : IDBQuizAnswerRepository
    {
        private readonly RaidenDBContext _dbContext;

        public QuizAnswerRepository(RaidenDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<string>> GetAnswersByQuestionIdAsync(int questionId)
        {
            return await _dbContext.QuizAnswers
                .Where(a => a.QuestionId == questionId)
                .Select(a => a.Text)
                .ToListAsync();
        }
        public async Task<QuizAnswer> CreateAnswerAsync(QuizAnswer answer)
        {
            _dbContext.QuizAnswers.Add(answer);
            await _dbContext.SaveChangesAsync();
            return answer;
        }

        public async Task<bool> DeleteAnswerAsync(int answerId)
        {
            var answer = await _dbContext.QuizAnswers.FindAsync(answerId);

            if (answer != null)
            {
                _dbContext.QuizAnswers.Remove(answer);
                await _dbContext.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}