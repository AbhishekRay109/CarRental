using Amazon.Runtime.Internal;
using Amazon.Util.Internal.PlatformServices;
using Assignment.Api.Interfaces;
using Assignment.Api.Interfaces.BlogEngineInterfaces;
using Assignment.Api.Models.BlogModels;
using Assignment.Service.Model;
using Assignment.Service.Model.BlogEngine;
using Assignment.Service.Services;
using Assignment.Service.Services.BlogServices;
using Assignment.Service.Services.EventRegistrationServices;
using Azure.Core;
using IdentityServer4.Models;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection.Emit;
using static IdentityModel.OidcConstants;

namespace Assignment.Api.Controllers
{
    [Route("api/v1/blogUser")]
    [ApiController]
    public class BlogUserController : ControllerBase
    {
        private readonly BlogUserServices _blogUserService;
        private readonly IDBBlogUserRepository _dbBlogUserRepository;
        private readonly AuthService _authService;



        public BlogUserController(BlogUserServices blogUserServices, IDBBlogUserRepository dBBlogUserRepository, AuthService authService)
        {
            _blogUserService = blogUserServices;
            _dbBlogUserRepository = dBBlogUserRepository;
            _authService = authService;
        }

        [ProducesResponseType(typeof(BlogUsers), 201)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]
        [HttpPost("username")]
        public async Task<ActionResult<BlogUserRS>> CreateBlogUser([FromBody] BlogUserRQ request)
        {
            try
            {
                var isUsernameExists = await _blogUserService.GetUsername(request.Username);

                if (isUsernameExists)
                {
                    return BadRequest(new { StatusCode = 400, Message = "Username already exists" });
                }

                if (string.IsNullOrWhiteSpace(request.Username))
                {
                    return BadRequest(new { StatusCode = 400, Message = "Username cannot be null or empty" });
                }
                if (!_blogUserService.isUsernameValid(request.Username))
                {
                    return BadRequest(new { StatusCode = 400, Message = "Invalid Username" });
                }
                var email = request.Email;

                if (string.IsNullOrWhiteSpace(email))
                {
                    return BadRequest(new { StatusCode = 400, Message = "Email ID cannot be blank" });
                }
                if (!_blogUserService.isEmailValid(email))
                {
                    return BadRequest(new { StatusCode = 400, Message = "Invalid Email ID" });
                }
                if(request.SubscriptionType != "Trial" || request.SubscriptionType != "Premium")
                {
                    return BadRequest(new { StatusCode = 400, Message = "Subscription Type can either be Trial or Premium" });
                }

                var createdUser = await _blogUserService.CreateUserAsync(request.Username, request);

                return Ok("User Created");
            

            }
            catch(Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex}");
            }
            
        }

        [HttpGet("")]
        [CustomAuthorize("blogauthor")]
        [ProducesResponseType(typeof(BlogUsers), 200)]
        [ProducesResponseType(typeof(string), 401)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<IActionResult> GetApplication(int userId)
        {
            try
            {
                string authorizationHeader = Request.Headers["Authorization"].ToString();
                string token = authorizationHeader.Replace("Bearer ", "");
                token = await _authService.DecryptJwt(token);
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;

                var blogUser = await _dbBlogUserRepository.GetUserIdByIdAsync(userId);
                if (blogUser == null || !blogUser.IsActive)
                {
                    return NotFound(new { StatusCode = 404, Message = "User Not Found" });
                }

                var responseModel = new BlogUserRS
                {
                    Username = blogUser.Username,
                    Email = blogUser.Email,
                    IsAuthor = blogUser.IsAuthor,
                    SubscriptionType = blogUser.SubscriptionType,
                    NumberOfPostAvailable = blogUser.NumberOfPostAvailable,
                    NumberOfPostRemaining = blogUser.NumberOfPostRemaining,
                    RegistrationDate = blogUser.RegistrationDate

                };
                return Ok(responseModel);
            }
            catch (Exception ex)
            {
                
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }


        [HttpDelete("unsubscribe")]
        [CustomAuthorize("blogauthor")]
        [ProducesResponseType(typeof(BlogUsers), 200)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<IActionResult> DeleteApplication(int userId)
        {
            try
            {
                string authorizationHeader = Request.Headers["Authorization"].ToString();
                string token = authorizationHeader.Replace("Bearer ", "");
                token = await _authService.DecryptJwt(token);
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
                string UserId = tokenClaim.Claims.FirstOrDefault(claim => claim.Type == "userId")?.Value;
                int tokenUserId = Convert.ToInt32(UserId);

                var blogUser = await _dbBlogUserRepository.GetUserIdByIdAsync(userId);
                if (blogUser == null || !blogUser.IsActive)
                {
                    return NotFound(new { StatusCode = 404, Message = "User Not Found" });
                }
                blogUser.IsActive = false;
                var unsubscribeduser = await _blogUserService.UpdateUserByIdAsync(userId, tokenUserId);

                if (unsubscribeduser != null)
                {
                    return Ok(new { StatusCode = 200, Message = "User Unsubscribed" });
                }
                return BadRequest("Invalid User ");

                
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

        [CustomAuthorize("blogauthor")]
        [HttpPut("")]
        [ProducesResponseType(typeof(BlogUsers), 200)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<IActionResult> UpdateAppSettings([Required] int userId, BlogUserUpdateRQ request)
        {
            try
            {
                string authorizationHeader = Request.Headers["Authorization"].ToString();
                string token = authorizationHeader.Replace("Bearer ", "");
                token = await _authService.DecryptJwt(token);

                if (string.IsNullOrWhiteSpace(request.Username))
                {
                    return BadRequest(new { StatusCode = 400, Message = "Username cannot be null or empty" });
                }

                if (!_blogUserService.isUsernameValid(request.Username))
                {
                    return BadRequest(new { StatusCode = 400, Message = "Invalid Username" });
                }

                var email = request.Email;

                if (string.IsNullOrWhiteSpace(email))
                {
                    return BadRequest(new { StatusCode = 400, Message = "Email ID cannot be blank" });
                }

                if (!_blogUserService.isEmailValid(email))
                {
                    return BadRequest(new { StatusCode = 400, Message = "Invalid Email ID" });
                }

                
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
                string UserId = tokenClaim.Claims.FirstOrDefault(claim => claim.Type == "userId")?.Value;
                int tokenUserId = Convert.ToInt32(UserId);

                if (tokenUserId.Equals(userId))
                {
                    var existingUser = await _blogUserService.GetUser(userId);

                    if (existingUser == null || !existingUser.IsActive)
                    {
                        return BadRequest(new { StatusCode = 400, Message = "User does not exists" });
                    }

                }
                else
                {
                    return BadRequest(new { StatusCode = 400, Message = "Invalid User, Check the Username or Password" });
                }

                var updateappModel = await _blogUserService.UpdateAsync(userId, request, tokenUserId);

                if (updateappModel != null)
                {

                    return Ok(new { StatusCode = 200, Message = "User Updated", updateappModel });
                }

                else
                {

                    return NotFound(new { StatusCode = 404, Message = "User Not Found" });

                }

            }
            catch (Exception ex)
            {
                
                return StatusCode(500, $"An error occurred: {ex}");
            }
        }

        [HttpPost("login")]
        public async Task<string> SignInUser([FromBody] BlogLoginRequest request)
        {
            return await _blogUserService.ValidateUserAsync(request);
        }



    }
}
