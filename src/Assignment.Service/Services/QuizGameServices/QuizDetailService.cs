using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.QuizGameInterfaces;
using Assignment.Api.Models.QuizGame;
using Assignment.Service.Model.QuizGame;

namespace Assignment.Service.Services.QuizGameServices
{
    public class QuizDetailService
    {
        private readonly IDBQuizDetailRepository _quizRepository;

        public QuizDetailService(IDBQuizDetailRepository quizRepository)
        {
            _quizRepository = quizRepository;
        }

        public async Task<IEnumerable<QuizDetailRS>> GetAllQuizDetailsAsync()
        {
            var quizDetails = await _quizRepository.GetAllQuizDetailsAsync();
            return quizDetails.Select(q => new QuizDetailRS
            {
                QuizId = q.QuizId,
                Title = q.Title,
                LevelName = q.Level?.Name,
                CategoryName = q.Category?.Name,
                NumberOfQuestions = q.NumberOfQuestions
            });
        }

        public async Task<QuizRS> CreateQuizAsync(QuizDetailRQ request)
        {
            if (!await _quizRepository.LevelExists(request.LevelId))
            {
                throw new ArgumentException($"LevelId does not exist.");
            }

            if (!await _quizRepository.CategoryExists(request.CategoryId))
            {
                throw new ArgumentException($"CategoryId does not exist.");
            }
            var quiz = new Quiz
            {
                Title = request.Title,
                LevelId = request.LevelId,
                CategoryId = request.CategoryId,
                NumberOfQuestions = request.NumberOfQuestions
            };

            var newQuizDetails = await _quizRepository.CreateQuizAsync(quiz);

            var quizDetails = new QuizRS
            {
                QuizId = newQuizDetails.QuizId,
                Title = request.Title,
                LevelId = request.LevelId,
                CategoryId = request.CategoryId,
                NumberOfQuestions = request.NumberOfQuestions
            };

            return quizDetails;
        }

        public async Task DeleteQuizAsync(int quizId)
        {
            await _quizRepository.DeleteQuizAsync(quizId);
        }
    }
}