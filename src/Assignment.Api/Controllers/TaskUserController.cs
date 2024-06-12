using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Assignment.Api.Interfaces;
using Assignment.Api.Middleware;
using Assignment.Api.Models;
using Assignment.Core.ThirdPartyModels;
using Assignment.Infrastructure.AuditLog;
using Assignment.Infrastructure.Notification;
using Assignment.Service.Model;
using Assignment.Service.Services;
using Swashbuckle.Swagger.Annotations;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.Identity.Client;
using Assignment.Service.Services.TaskUserServices;
using Assignment.Core.Models.TaskManagement;

namespace Assignment.Api.Controllers
{
    [Route("task-users")]
    [ApiController]
    public class TaskUserController : BaseController
    {
        private readonly TaskUserService _taskUserService;
        private readonly Serilog.Core.Logger logger;
        private readonly AuthService _authService;

        public TaskUserController(TaskUserService taskUserService,AuthService authService, Serilog.Core.Logger logger) : base(logger)
        {
            _taskUserService = taskUserService;
            this.logger = logger;
            _authService = authService;
        }
        
         /// <summary>
        /// Create new user profile. A user can register himself as administrator or common user.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>   
        /// <response code="401"> Unauthorized - User don't have access.</response>
        /// <response code="403"> Forbidden - The User is Forbidden.</response>
        [HttpPost("signup")]
        public async Task<TaskUsers> SignUpUser([FromBody] TaskUserSignupRQ taskUserSignupRQ)
        {
            return await _taskUserService.SignUpAsync(taskUserSignupRQ);
        }

      
         /// <summary>
        /// This Api is used to login for already existing users and generates token .
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>   
        /// <response code="401"> Unauthorized - User don't have access.</response>
        /// <response code="403"> Forbidden - The User is Forbidden.</response>
        [HttpPost("signin")]
        public async Task<IActionResult> SignInUser([FromBody] AuthRQ authRQ)
        {
            string jwtToken = await _authService.GenerateJwtTokenForAdmin(authRQ.Email,authRQ.Password);
            if (!string.IsNullOrEmpty(jwtToken))
            {
                return Ok(new { Token = jwtToken });
            }
            else
            {
                return NotFound(new { Message = "Invalid email or password" });
            }
            
        }
    }
}
