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
    [Route("")]
    public class QuizDetailController : ControllerBase
    {
        private readonly QuizDetailService _quizService;

        public QuizDetailController(QuizDetailService quizService)
        {
            _quizService = quizService;
        }

        /// <summary>
        /// This API is used to fetch all quiz details.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("/details")]
        [CustomAuthorize("quiz-user")]
        public async Task<IActionResult> GetAllQuizDetails()
        {
            try
            {
                var quizDetails = await _quizService.GetAllQuizDetailsAsync();
                return Ok(ResponseHandler.HandleSuccess("Quiz details fetched successfully",quizDetails));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<Quiz>("BadRequest", ex.Message));
            }
        }

        /// <summary>
        /// This API is used to post quiz detail.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost("/detail")]
        [CustomAuthorize("quiz-admin")]
        public async Task<IActionResult> CreateQuizAsync([FromBody] QuizDetailRQ request)
        {
            try
            {
                var result = await _quizService.CreateQuizAsync(request);
                return Ok(ResponseHandler.HandleSuccess("Quiz details added successfully",result));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<Quiz>("BadRequest", ex.Message));
            }
        }

        /// <summary>
        /// This API is used to delete a quiz detail.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpDelete("/detail/{quizId}")]
        [CustomAuthorize("quiz-admin")]
        public async Task<IActionResult> DeleteQuizAsync(int quizId)
        {
            try
            {
                await _quizService.DeleteQuizAsync(quizId);
                return Ok("Quiz deleted successfully.");
            }
            catch (ArgumentException ex)
            {
                return Ok(ResponseHandler.HandleError<Quiz>("BadRequest", ex.Message));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<Quiz>("BadRequest", ex.Message));
            }
        }
    }
}