using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.QuizGameInterfaces;
using Assignment.Api.Models.QuizGame;
using Assignment.Service.Model.QuizGame;

namespace Assignment.Service.Services.QuizGameServices
{
    public class QuizAnswerService
    {
        private readonly IDBQuizAnswerRepository _answerRepository;

        public QuizAnswerService(IDBQuizAnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
        }

        public async Task<List<string>> GetAnswersByQuestionIdAsync(int questionId)
        {
            return await _answerRepository.GetAnswersByQuestionIdAsync(questionId);
        }

        public async Task<QuizAnswerRS> CreateAnswerAsync(QuizAnswerRQ answer)
        {
            var answerModel = new QuizAnswer
            {
                Text = answer.Text,
                IsCorrect = answer.IsCorrect,
                QuestionId = answer.QuestionId
            };

            var createdAnswer = await _answerRepository.CreateAnswerAsync(answerModel);

            var answerResponse = new QuizAnswerRS
            {
                AnswerId = createdAnswer.AnswerId,
                Text = createdAnswer.Text,
                IsCorrect = createdAnswer.IsCorrect,
                QuestionId = createdAnswer.QuestionId
            };

            return answerResponse;
        }

        public async Task<bool> DeleteAnswerAsync(int answerId)
        {
            return await _answerRepository.DeleteAnswerAsync(answerId);
        }
    }
}