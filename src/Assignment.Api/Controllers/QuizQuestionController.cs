using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models.QuizGame;
using Assignment.Service.Model.QuizGame;
using Assignment.Service.Model.ResponseHandler;
using Assignment.Service.Services.QuizGameServices;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Api.Controllers
{
    [ApiController]
    [Route("/question")]
    public class QuizQuestionController : ControllerBase
    {
        private readonly QuizQuestionService _questionService;

        public QuizQuestionController(QuizQuestionService questionService)
        {
            _questionService = questionService;
        }

        /// <summary>
        /// This API is used to get all quiz questions.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [CustomAuthorize("quiz-admin")]
        public async Task<IActionResult> GetAllQuizQuestionsAsync()
        {
            try
            {
                var questions = await _questionService.GetAllQuizQuestionsAsync();
                return Ok(ResponseHandler.HandleSuccess("Question fetched successfully",questions));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<QuizQuestion>("BadRequest", ex.Message));
            }
        }

        /// <summary>
        /// This API is used to post a new quiz question.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [CustomAuthorize("quiz-admin")]
        public async Task<IActionResult> CreateQuestionAsync([FromBody] QuizQuestionRQ question)
        {
            try
            {
                var createdQuestion = await _questionService.CreateQuestionAsync(question);
                return Ok(ResponseHandler.HandleSuccess("Question added successfully",createdQuestion));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<QuizQuestion>("BadRequest", ex.Message));
            }
        }

        /// <summary>
        /// This API is used to delete a quiz question.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpDelete("{questionId}")]
        [CustomAuthorize("quiz-admin")]
        public async Task<IActionResult> DeleteQuestionAsync(int questionId)
        {
            try
            {
                var isDeleted = await _questionService.DeleteQuestionAsync(questionId);

                if (isDeleted)
                    return Ok("Question deleted successfully");
                else
                    return NotFound($"Question with ID {questionId} not found");
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<QuizQuestion>("BadRequest", ex.Message));
            }
        }
    }
}