using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.QuizGameInterfaces;
using Assignment.Api.Models.QuizGame;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Infrastructure.Repository.QuizGameRepositories
{
    public class QuizQuestionRepository : IDBQuizQuestionRepository
    {
        private readonly RaidenDBContext _dbContext;

        public QuizQuestionRepository(RaidenDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<QuizQuestion>> GetAllQuizQuestionsAsync()
        {
            var questions = await _dbContext.QuizQuestions.ToListAsync();
            return questions;
        }
        
        public async Task<QuizQuestion> CreateQuestionAsync(QuizQuestion question)
        {
            _dbContext.QuizQuestions.Add(question);
            await _dbContext.SaveChangesAsync();
            return question;
        }

        public async Task<bool> DeleteQuestionAsync(int questionId)
        {
            var question = await _dbContext.QuizQuestions.FindAsync(questionId);

            if (question != null)
            {
                _dbContext.QuizQuestions.Remove(question);
                await _dbContext.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}