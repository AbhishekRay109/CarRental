using Assignment.Service.Model;
using Assignment.Service.Model.ResponseHandler;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Assignment.Infrastructure.Repository;
using Assignment.Service.Services;
using Assignment.Api.Interfaces;
using Assignment.Service.Model.BookLibrary;
using Assignment.Service.Services.BookLibraryService;
using Assignment.Api.Interfaces.BookLibraryInterfaces;


namespace Assignment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookUserController : ControllerBase
    {
        private readonly BookUserService _bookUserService;
        private readonly AuthService _authService;
        private readonly IDBBookUserRepository _userRepository; 



        public BookUserController(BookUserService bookUserService, AuthService authService, IDBBookUserRepository userRepository)
        {
            _bookUserService = bookUserService ?? throw new ArgumentNullException(nameof(bookUserService));
            _authService = authService;
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository)); 


        }

        /// <summary>
        /// Gets all book users.
        /// </summary>
        /// <returns>A list of book users.</returns>
        /// 200 OK - Success.
        /// <response code="400"> Bad Request </response> 
        /// <response code="500"> Internal Server Error </response>
        /// <response code="401"> Unauthorized </response>
        /// <response code="403"> Forbidden </response>
        /// <response code="404"> Not Found </response>

        [HttpGet]
        [CustomAuthorize("book-user")]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var users = await _bookUserService.GetAllUsersAsync();
                return Ok(ResponseHandler.HandleSuccess("Successfully fetched users", users));
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ResponseHandler.HandleError<List<BookUser>>(HttpStatusCode.InternalServerError.ToString(), ex.Message));
            }
        }

        /// <summary>
        /// Gets a book user by ID.
        /// </summary>
        /// <param name="userId">The ID of the book user.</param>
        /// <returns>The requested book user.</returns>
        /// 200 OK - Success.
        /// <response code="400"> Bad Request </response> 
        /// <response code="500"> Internal Server Error </response>
        /// <response code="401"> Unauthorized </response>
        /// <response code="403"> Forbidden </response>
        /// <response code="404"> Not Found </response>

        [HttpGet("{userId}")]
        [CustomAuthorize("book-user")]

        public async Task<IActionResult> GetUserById(int userId)
        {
            try
            {
                var user = await _bookUserService.GetUserByIdAsync(userId);
                return Ok(user != null
                    ? ResponseHandler.HandleSuccess("Successfully fetched user", user)
                    : ResponseHandler.HandleError<BookUser>("NotFound", $"User with ID {userId} not found"));
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ResponseHandler.HandleError<BookUser>(HttpStatusCode.InternalServerError.ToString(), ex.Message));
            }
        }

        /// <summary>
        /// Adds a new book user.
        /// </summary>
        /// <param name="userRequest">The request object containing book user details.</param>
        /// <returns>The newly created book user.</returns>
        /// 200 OK - Success.
        /// <response code="400"> Bad Request </response> 
        /// <response code="500"> Internal Server Error </response>
        /// <response code="401"> Unauthorized </response>
        /// <response code="403"> Forbidden </response>
        /// <response code="404"> Not Found </response>

        [HttpPost]
        public async Task<IActionResult> AddUserAsync([FromBody] BookUserRQ userRequest)
        {
            try
            {
                var createdUser = await _bookUserService.CreateUserAsync(userRequest);
                return Ok(ResponseHandler.HandleSuccess<BookUserRS>("User added successfully", createdUser));
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ResponseHandler.HandleError<BookUserRS>(HttpStatusCode.InternalServerError.ToString(), ex.Message));
            }
        }


        /// <summary>
        /// Login.
        /// </summary>
        /// <param name="loginRequest">The request object to user name.</param>
        /// <returns>The login.</returns>
        /// 200 OK - Success.
        /// <response code="400"> Bad Request </response> 
        /// <response code="500"> Internal Server Error </response>
        /// <response code="401"> Unauthorized </response>
        /// <response code="403"> Forbidden </response>
        /// <response code="404"> Not Found </response>

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginRequest loginRequest)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var isLoginSuccessful = await _bookUserService.LoginAsync(loginRequest.Username, loginRequest.Password);

                if (isLoginSuccessful)
                {
                    return Ok(new { Message = "Login successful" });
                }

                return Unauthorized(new { Message = "Invalid username or password" });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ResponseHandler.HandleError<object>(HttpStatusCode.InternalServerError.ToString(), ex.Message));
            }
        }

        /// <summary>
        /// Gets all book users.
        /// </summary>
        /// <returns>A list of book users.</returns>
        /// 200 OK - Success.
        /// <response code="400"> Bad Request </response> 
        /// <response code="500"> Internal Server Error </response>
        /// <response code="401"> Unauthorized </response>
        /// <response code="403"> Forbidden </response>
        /// <response code="404"> Not Found </response>
        
        [HttpPost("Token")]
        public async Task<string> GenerateTokenForUser(string username, string password)
        {
            try
            {
                var bookAdminUserName = Environment.GetEnvironmentVariable("BookAdmin_UserName");
                var bookAdminPassword = Environment.GetEnvironmentVariable("BookAdmin_Password");
                var isValidUser = await LoginAsync(username, password);

                if (isValidUser || (username == bookAdminUserName && password == bookAdminPassword))
                {
                    var accessToken = await _authService.GenerateJwtTokenForBook(username);
                    return accessToken;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private async Task<bool> LoginAsync(string email, string password)
        {
            try
            {
                var user = await _userRepository.GetUserByUserNameAsync(email);

                if (user == null)
                {
                    return false;
                }

                var isPasswordValid = VerifyPasswordHash(password, user.PasswordHash);

                return isPasswordValid;
            }
            catch (Exception)
            {
                return false;
            }
        }


        /// <summary>
        /// Checks if a user with the given username and password exists in the database.
        /// </summary>
        /// <param name="loginRequest">The request object containing username and password.</param>
        /// <returns>True if the user exists, false otherwise.</returns>
        /// <response code="200">OK - Success.</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="500">Internal Server Error.</response>
        [HttpPost("checkuser")]
        public async Task<IActionResult> CheckUserAsync([FromBody] LoginRequest loginRequest)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var userExists = await _bookUserService.UserExistsAsync(loginRequest.Username, loginRequest.Password);

                return Ok(new { UserExists = userExists });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ResponseHandler.HandleError<object>(HttpStatusCode.InternalServerError.ToString(), ex.Message));
            }
        }

        private bool VerifyPasswordHash(string password, string storedHash)
        {
            return password == storedHash;
        }

    }
}