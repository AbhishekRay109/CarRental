using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models.QuizGame;
using Assignment.Service.Model.QuizGame;
using Assignment.Service.Model.ResponseHandler;
using Assignment.Service.Services;
using Assignment.Service.Services.QuizGameServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace Assignment.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class QuizPlayController : ControllerBase
    {
        private readonly QuizPlayService _quizPlayService;
        private readonly AuthService _authService;

        public QuizPlayController(QuizPlayService quizPlayService, AuthService authService)
        {
            _quizPlayService = quizPlayService;
            _authService = authService;
        }

        /// <summary>
        /// This API is used to play the quiz, where the user will get all questions and answers.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response> 
        [HttpGet("view")]
        [CustomAuthorize("quiz-user")]
        public async Task<IActionResult> GetQuizQuestionsAsync([Required] int quizId)
        {
            try
            {
                var result = await _quizPlayService.GetQuizQuestionsAsync(quizId);

                if (result is string message)
                {
                    return Ok(message);
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<Quiz>("BadRequest", ex.Message));
            }
        }

        /// <summary>
        /// This API is used to submit the quiz, where the user will enter the questionid and its answerid respectively.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response> 
        [HttpPost("play")]
        [CustomAuthorize("quiz-user")]
        public async Task<IActionResult> SubmitAnswerAsync([FromQuery] QuizPlayRQ request)
        {
            try
            {

                var email = await CheckParams();
                if (email.Equals(request.Email))
                {
                    var result = await _quizPlayService.SubmitAnswerAsync(request);
                    return Ok(result);
                }
                return Unauthorized("You are not authorized");
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<Quiz>("BadRequest", ex.Message));
            }
        }

        private async Task<string> CheckParams()
        {
            try
            {
                string JwtToken = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
                JwtToken = await _authService.DecryptJwt(JwtToken);
                var handler = new JwtSecurityTokenHandler();
                var tokens = handler.ReadJwtToken(JwtToken);
                var claims = tokens.Claims;
                var emailId = claims.FirstOrDefault(c => c.Type == "email")?.Value;
                return emailId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}