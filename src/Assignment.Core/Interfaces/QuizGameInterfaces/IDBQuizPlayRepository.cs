using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models.QuizGame;

namespace Assignment.Api.Interfaces.QuizGameInterfaces
{
    public interface IDBQuizPlayRepository
    {
        Task<bool> DoesEmailExistAsync(string email);
        Task<object> GetQuizQuestionsAsync(int quizId);
        Task<QuizUser> ValidateUserCredentialsAsync(string email, string password);
        Task<string> GetLevelNameByQuizIdAsync(int quizId);
        Task<int> GetLevelIdByQuestionIdAsync(int questionId);
        Task<int> GetQuizIdByLevelOrCategoryAsync(int levelId);
        Task<bool> IsAnswerCorrectAsync(int questionId, string quizType, List<string> userAnswers);
        Task<bool> IsValidQuestionAnswerAsync(int questionId, string quizType, List<string> userAnswers);
        Task UpdateUserScoreAsync(string email, int score, int levelId, int quizId, int questionId);
        Task<bool> HasUserAnsweredQuestionAsync(int userId, int levelId, int questionId);
        Task<string> GetQuizTypeByLevelIdAsync(int levelId);
    }
}