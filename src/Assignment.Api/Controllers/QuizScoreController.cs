using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models.QuizGame;
using Assignment.Service.Model.ResponseHandler;
using Assignment.Service.Services.QuizGameServices;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class QuizScoreController : ControllerBase
    {
        private readonly QuizScoreService _quizScoreService;

        public QuizScoreController(QuizScoreService quizScoreService)
        {
            _quizScoreService = quizScoreService;
        }

        /// <summary>
        /// This API is used to fetch user's score.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("score")]
        [CustomAuthorize("quiz-user")]
        public async Task<IActionResult> GetScoreByUserIdAndQuizIdAsync([Required]int userId,[Required] int quizId)
        {
            try
            {
                var score = await _quizScoreService.GetScoreDetailsByUserIdAndQuizIdAsync(userId, quizId);
                return Ok(ResponseHandler.HandleSuccess("Score fetched successfully",score));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<QuizScore>("BadRequest", ex.Message));
            }
        }


        /// <summary>
        /// This API is used to export the leaderboard.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("leaderboard")]
        [CustomAuthorize("quiz-user")]
        public async Task<IActionResult> ExportLeaderboardPDF()
        {
            try
            {
                var response = await _quizScoreService.GenerateLeaderboardPDF();
                return File(response, "application/pdf", "QuizLeaderboard.pdf");
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<QuizScore>("BadRequest", ex.Message));
            }
        }
    }
}