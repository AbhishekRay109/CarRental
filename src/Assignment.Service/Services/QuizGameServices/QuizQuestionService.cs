using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.QuizGameInterfaces;
using Assignment.Api.Models.QuizGame;
using Assignment.Service.Model.QuizGame;

namespace Assignment.Service.Services.QuizGameServices
{
    public class QuizQuestionService
    {
        private readonly IDBQuizQuestionRepository _questionRepository;

        public QuizQuestionService(IDBQuizQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public async Task<List<QuizQuestionRS>> GetAllQuizQuestionsAsync()
        {
            var questions = await _questionRepository.GetAllQuizQuestionsAsync();

            List<QuizQuestionRS> res = new List<QuizQuestionRS>();
            foreach(var question in questions)
            {
                res.Add(new QuizQuestionRS()
                {
                    QuestionId = question.QuestionId,
                    Text = question.Text,
                    CategoryId = question.CategoryId
                });
            }

            return res;
        }

        public async Task<QuizQuestionRS> CreateQuestionAsync(QuizQuestionRQ question)
        {

            var questionModel = new QuizQuestion
            {
                Text = question.Text,
                CategoryId = question.CategoryId
            };

            var createdQuestion = await _questionRepository.CreateQuestionAsync(questionModel);

            var questionResponse = new QuizQuestionRS
            {
                QuestionId = createdQuestion.QuestionId,
                Text = createdQuestion.Text,
                CategoryId = createdQuestion.CategoryId
            };

            return questionResponse;
        }

        public async Task<bool> DeleteQuestionAsync(int questionId)
        {
            return await _questionRepository.DeleteQuestionAsync(questionId);
        }
    }
}