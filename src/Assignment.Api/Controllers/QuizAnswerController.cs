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
    [Route("/answer")]
    public class QuizAnswerController : ControllerBase
    {
        private readonly QuizAnswerService _answerService;

        public QuizAnswerController(QuizAnswerService answerService)
        {
            _answerService = answerService;
        }

        /// <summary>
        /// This API is used to fetch answer based on questionId.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("{questionId}")]
        [CustomAuthorize("quiz-admin")]
        public async Task<IActionResult> GetAnswersByQuestionId(int questionId)
        {
            try
            {
                var answers = await _answerService.GetAnswersByQuestionIdAsync(questionId);
                return Ok(ResponseHandler.HandleSuccess("Answer fetched successfully",answers));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<QuizAnswer>("BadRequest", ex.Message));
            }
        }

        /// <summary>
        /// This API is used to post an answer for a question.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [CustomAuthorize("quiz-admin")]
        public async Task<IActionResult> CreateAnswerAsync([FromBody] QuizAnswerRQ answer)
        {
            try
            {
                var createdAnswer = await _answerService.CreateAnswerAsync(answer);
                return Ok(ResponseHandler.HandleSuccess("Answer added successfully",createdAnswer));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<QuizAnswer>("BadRequest", ex.Message));
            }
        }

        /// <summary>
        /// This API is used to delete an answer.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpDelete("{answerId}")]
        [CustomAuthorize("quiz-admin")]
        public async Task<IActionResult> DeleteAnswerAsync(int answerId)
        {
            try
            {
                var isDeleted = await _answerService.DeleteAnswerAsync(answerId);

                if (isDeleted)
                    return Ok("Answer deleted successfully");
                else
                    return NotFound($"Answer with ID {answerId} not found");
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<QuizAnswer>("BadRequest", ex.Message));
            }
        }
    }
}