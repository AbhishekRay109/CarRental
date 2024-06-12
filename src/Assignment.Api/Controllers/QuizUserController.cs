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
using Assignment.Service.Services.QuizGame;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace Assignment.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class QuizUserController : ControllerBase
    {
        private readonly QuizUserService _userService;
        private readonly AuthService _authService;

        public QuizUserController(QuizUserService userService, AuthService authService)
        {
            _authService = authService;
            _userService = userService;
        }

        /// <summary>
        /// This API is used to generate token.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>

        [HttpPost("login")]
        public async Task<IActionResult> GenerateToken([FromBody] QuizLoginRQ quizLoginRQ)
        {
            try
            {
                var quizAdminEmail = Environment.GetEnvironmentVariable("QuizAdmin_Email");
                var quizAdminPassword = Environment.GetEnvironmentVariable("QuizAdmin_Password");

                var isValidUser = _userService.IsValidUser(quizLoginRQ.Email, quizLoginRQ.Password);

                if (isValidUser || (quizLoginRQ.Email == quizAdminEmail && quizLoginRQ.Password == quizAdminPassword))
                {
                    var accessToken = await _authService.GenerateJwtTokenForQuiz(quizLoginRQ.Email);
                    return Ok(accessToken);
                }
                else
                {
                    return StatusCode(401, "You are not Authorized");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        /// <summary>
        /// This API is used to create a new user.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>   
        [HttpPost("/user/register")]
        public async Task<IActionResult> RegisterUserAsync([FromBody] QuizUserRQ user)
        {
            try
            {
                var registeredUser = await _userService.RegisterUserAsync(user);
                return Ok(ResponseHandler.HandleSuccess("User added successfully",registeredUser));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<QuizUser>("BadRequest", ex.Message));
            }
        }

        /// <summary>
        /// This API is used to fetch all users.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>

        [HttpGet("quiz/users")]
        [CustomAuthorize("quiz-admin")]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            try
            {
                var users = await _userService.GetAllUsersAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<QuizUser>("BadRequest", ex.Message));
            }
        }

        /// <summary>
        /// This API is used to update user details by userId.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPut("user/{userId}")]
        [CustomAuthorize("quiz-user")]
        public async Task<IActionResult> UpdateUserAsync(int userId, [FromBody] QuizUserRQ updatedUserData)
        {
            try
            {
                var email = await CheckParams();
                if (email.Equals(updatedUserData.Email))
                {
                    var updatedUser = await _userService.UpdateUserAsync(userId, updatedUserData);
                    return Ok(ResponseHandler.HandleSuccess("User data updated successfully",updatedUser));
                }
                else
                {
                    return Unauthorized("You are not authorized");
                }

            }
            catch (KeyNotFoundException ex)
            {
                return Ok(ResponseHandler.HandleError<QuizUser>("Not Found", ex.Message));
            }
            catch (ArgumentException ex)
            {
                return Ok(ResponseHandler.HandleError<QuizUser>("BadRequest", ex.Message));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<QuizUser>("BadRequest", ex.Message));
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