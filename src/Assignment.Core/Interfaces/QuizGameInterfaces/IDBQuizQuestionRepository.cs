using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models.QuizGame;

namespace Assignment.Api.Interfaces.QuizGameInterfaces
{
    public interface IDBQuizQuestionRepository
    {
        Task<List<QuizQuestion>> GetAllQuizQuestionsAsync();
        Task<QuizQuestion> CreateQuestionAsync(QuizQuestion question);
        Task<bool> DeleteQuestionAsync(int questionId);
    }
}