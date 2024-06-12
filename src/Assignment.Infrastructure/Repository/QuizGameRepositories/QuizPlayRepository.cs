using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.QuizGameInterfaces;
using Assignment.Api.Models.QuizGame;
using Assignment.Api.Models.QuizGameModels;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Infrastructure.Repository.QuizGameRepositories
{
    public class QuizPlayRepository : IDBQuizPlayRepository
    {
        private readonly RaidenDBContext _dbContext;

        public QuizPlayRepository(RaidenDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> DoesEmailExistAsync(string email)
        {
            return await _dbContext.QuizUsers.AnyAsync(u => u.Email == email);
        }
        public async Task<object> GetQuizQuestionsAsync(int quizId)
        {
            try
            {
                var quiz = await _dbContext.Quiz
                .Include(q => q.QuizQuestions)
                .FirstOrDefaultAsync(q => q.QuizId == quizId);

                if (quiz == null)
                {
                    return "Invalid QuizId. Unable to retrieve questions.";
                }

                var numberOfQuestions = quiz.NumberOfQuestions;
                var questions = _dbContext.QuizQuestions
                .Include(q => q.QuizAnswers)
                .Where(q => q.Category.Quizzes.Any(quiz => quiz.QuizId == quizId)).OrderBy(q => Guid.NewGuid()).Take(numberOfQuestions).ToList();

                return questions;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> GetLevelNameByQuizIdAsync(int quizId)
        {
            return await _dbContext.QuizLevels
                .Where(l => l.Quizzes.Any(q => q.QuizId == quizId))
                .Select(l => l.Name)
                .FirstOrDefaultAsync();
        }

        public async Task<int> GetQuizIdByLevelOrCategoryAsync(int levelId)
        {
            var quizId = await _dbContext.Quiz
                .Where(q => q.LevelId == levelId)
                .Select(q => q.QuizId)
                .FirstOrDefaultAsync();

            return quizId;
        }

        public async Task<QuizUser> ValidateUserCredentialsAsync(string email, string password)
        {
            return await _dbContext.QuizUsers.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
        }


        public async Task<bool> IsAnswerCorrectAsync(int questionId, int answerId)
        {
            var correctAnswer = await _dbContext.QuizAnswers
                .FirstOrDefaultAsync(answer => answer.QuestionId == questionId && answer.AnswerId == answerId && answer.IsCorrect == true);

            return correctAnswer != null;
        }

        public async Task<int> GetLevelIdByQuestionIdAsync(int questionId)
        {
            var levelId = await _dbContext.QuizQuestions
                .Where(q => q.QuestionId == questionId)
                .Select(q => q.Category.LevelId)
                .FirstOrDefaultAsync();

            if (levelId == null)
            {
                return 0;
            }
            return (int)levelId;
        }

        public async Task<bool> HasUserAnsweredQuestionAsync(int userId, int levelId, int questionId)
        {
            return await _dbContext.QuizAnsweredQuestion
            .Where(aq => aq.UserId == userId && aq.LevelId == levelId && aq.QuestionId == questionId)
            .AnyAsync();

        }

        public async Task UpdateUserScoreAsync(string email, int score, int levelId, int quizId, int questionId)
        {
            var user = await _dbContext.QuizUsers.FirstOrDefaultAsync(u => u.Email == email);

            if (user != null)
            {
                var existingScore = await _dbContext.QuizScores.FirstOrDefaultAsync(
                    s => s.UserId == user.UserId && s.LevelId == levelId && s.QuizId == quizId);

                if (existingScore != null)
                {
                    existingScore.Score += score;
                    _dbContext.QuizScores.Update(existingScore);
                }
                else
                {
                    var newScore = new QuizScore
                    {
                        UserId = user.UserId,
                        LevelId = levelId,
                        Score = score,
                        QuizId = quizId
                    };

                    _dbContext.QuizScores.Add(newScore);
                }

                var answeredQuestion = new QuizAnsweredQuestion
                {
                    UserId = user.UserId,
                    LevelId = levelId,
                    QuizId = quizId,
                    QuestionId = questionId
                };

                _dbContext.QuizAnsweredQuestion.Add(answeredQuestion);

                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<bool> IsValidQuestionAnswerAsync(int questionId, string quizType, List<string> userAnswers)
        {
            if (quizType == "MCQ")
            {
                var correctAnswers = await _dbContext.QuizAnswers
                    .Where(a => a.QuestionId == questionId && a.IsCorrect == true)
                    .Select(a => a.AnswerId.ToString())
                    .ToListAsync();

                var isValid = correctAnswers
                    .OrderBy(a => a)
                    .SequenceEqual(userAnswers.OrderBy(a => a));

                return isValid;
            }
            else if (quizType == "Typing")
            {
                var correctAnswer = await _dbContext.QuizAnswers
                    .Where(a => a.QuestionId == questionId && a.IsCorrect == true)
                    .Select(a => a.Text)
                    .FirstOrDefaultAsync();

                return correctAnswer != null && userAnswers.Contains(correctAnswer);
            }

            return false;
        }


        public async Task<bool> IsAnswerCorrectAsync(int questionId, string quizType, List<string> userAnswers)
        {
            if (quizType == "MCQ")
            {
                return await IsValidQuestionAnswerAsync(questionId, quizType, userAnswers);
            }
            else if (quizType == "Typing")
            {
                var correctAnswer = await _dbContext.QuizAnswers
                    .Where(a => a.QuestionId == questionId && a.IsCorrect == true)
                    .Select(a => a.Text)
                    .FirstOrDefaultAsync();

                return correctAnswer != null && userAnswers.Contains(correctAnswer);
            }

            return false;
        }

        public async Task<string> GetQuizTypeByLevelIdAsync(int levelId)
        {
            var quizType = await _dbContext.QuizLevels
                .Where(l => l.LevelId == levelId)
                .Select(l => l.QuizType)
                .FirstOrDefaultAsync();

            return quizType;
        }
    }
}