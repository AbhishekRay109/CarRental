using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.QuizGameInterfaces;
using Assignment.Api.Models.QuizGame;
using Assignment.Service.Model.QuizGame;

namespace Assignment.Service.Services.QuizGameServices
{
    public class QuizPlayService
    {
        private readonly IDBQuizPlayRepository _quizPlayRepository;

        public QuizPlayService(IDBQuizPlayRepository quizPlayRepository)
        {
            _quizPlayRepository = quizPlayRepository;
        }

        public async Task<bool> DoesEmailExistAsync(string email)
        {
            return await _quizPlayRepository.DoesEmailExistAsync(email);
        }

        public async Task<object> GetQuizQuestionsAsync(int quizId)
        {
            try
            {
                var result = await _quizPlayRepository.GetQuizQuestionsAsync(quizId);

                if (result is string message)
                {
                    return message;
                }

                var levelName = await _quizPlayRepository.GetLevelNameByQuizIdAsync(quizId);

                if (levelName.ToLower() == "pro")
                {
                    var proLevelQuestions = FormatProLevelQuestions((List<QuizQuestion>)result);
                    return proLevelQuestions;
                }
                else
                {
                    var formattedQuestions = ((List<QuizQuestion>)result).Select(FormatQuizQuestion).ToList();
                    return formattedQuestions;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private object FormatQuizQuestion(QuizQuestion question)
        {
            var formattedQuestion = new QuizPlayRS
            {
                QuestionId = question.QuestionId,
                Text = question.Text,
                Answers = FormatQuizAnswers(question.QuizAnswers)
            };

            return formattedQuestion;
        }

        private List<QuizAnswers> FormatQuizAnswers(IEnumerable<QuizAnswer> answers)
        {
            var randomizedAnswers = answers.OrderBy(a => Guid.NewGuid()).Take(4);

            return randomizedAnswers.Select(answer => new QuizAnswers
            {
                AnswerId = answer.AnswerId,
                Text = answer.Text
            }).ToList();
        }

        private List<QuizProPlay> FormatProLevelQuestions(List<QuizQuestion> questions)
        {
            return questions.Select(question => new QuizProPlay
            {
                QuestionId = question.QuestionId,
                Text = question.Text
            }).ToList();
        }

        public async Task<string> SubmitAnswerAsync(QuizPlayRQ request)
        {
            var user = await _quizPlayRepository.ValidateUserCredentialsAsync(request.Email, request.Password);

            if (user == null)
            {
                return "Invalid credentials. Unable to submit answer.";
            }

            var levelId = await _quizPlayRepository.GetLevelIdByQuestionIdAsync(request.QuestionId);

            var quizType = await _quizPlayRepository.GetQuizTypeByLevelIdAsync(levelId);

            var isValidQuestionAnswer = await _quizPlayRepository.IsValidQuestionAnswerAsync(request.QuestionId, quizType, request.Answer);

            if (!isValidQuestionAnswer)
            {
                return "Invalid Input Data";
            }

            int userId = user.UserId;
            bool hasAnswered = await _quizPlayRepository.HasUserAnsweredQuestionAsync(userId, levelId, request.QuestionId);

            if (hasAnswered)
            {
                return "You have already answered this question. Proceed to the next question.";
            }

            bool isCorrect = await _quizPlayRepository.IsAnswerCorrectAsync(request.QuestionId, quizType, request.Answer);
            int quizId = await _quizPlayRepository.GetQuizIdByLevelOrCategoryAsync(levelId);

            if (isCorrect)
            {
                int score = CalculateScore();

                await _quizPlayRepository.UpdateUserScoreAsync(request.Email, score, levelId, quizId, request.QuestionId);

                return "Correct answer!";
            }
            else
            {
                return "Incorrect answer. Try again!";
            }
        }

        private int CalculateScore()
        {
            return 1;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
