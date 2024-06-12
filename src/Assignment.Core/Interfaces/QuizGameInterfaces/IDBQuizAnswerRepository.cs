using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models.QuizGame;

namespace Assignment.Api.Interfaces.QuizGameInterfaces
{
    public interface IDBQuizAnswerRepository
    {
        Task<List<string>> GetAnswersByQuestionIdAsync(int questionId);
        Task<QuizAnswer> CreateAnswerAsync(QuizAnswer answer);
        Task<bool> DeleteAnswerAsync(int answerId);
    }
}