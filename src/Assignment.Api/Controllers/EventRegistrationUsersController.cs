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
using Assignment.Service.Services.EventRegistrationServices;
using Assignment.Service.Model.EventRegistration;


namespace Assignment.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("event-registration-users")]
    [ApiController]
    public class EventRegistrationUsersController : BaseController
    {
        private readonly ILogger<EventRegistrationUsersController> _logger;
        private readonly EventRegistrationUserService _eventRegistrationUserService;
        private readonly Serilog.Core.Logger logger;
        public EventRegistrationUsersController(EventRegistrationUserService eventRegistrationUserService, Serilog.Core.Logger logger) : base(logger)
        {
            _eventRegistrationUserService = eventRegistrationUserService;
            this.logger = logger;
        }

        /// <summary>
        /// Create new user profile. A user can register himself as audience or event organizer.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost("signup")]
        public async Task<EventRegistrationUsers> SignUpUser([FromBody] EventRegistrationSignupRQ eventRegistrationRQ)
        {
            return await _eventRegistrationUserService.SignUpAsync(eventRegistrationRQ);
        }

        /// <summary>
        /// This endpoint is used for generating the access token.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost("signin")]
        public async Task<string> SignInUser([FromBody] AuthRQ authRQ)
        {
            return await _eventRegistrationUserService.AuthenticationAsync(authRQ);
        }

        /// <summary>
        /// This API is used for the email validation for the user. User should provide OTP here for validation.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPut("validate-email")]
        public async Task<IActionResult> ValidateUser([FromBody] EventRegistrationOtpModel otpModel)
        {
            var rs = await _eventRegistrationUserService.OtpValidationAsync(otpModel, otpModel.Email);
            if (rs)
            {
                return Ok("Verfied Successfully");
            }
            else
            {
                return Ok("verification Failed");
            }
        }

        /// <summary>
        /// This API is used for the email validation for the user. User should provide OTP here for validation.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost("resend-otp")]
        public async Task<string> ResendOtp([FromBody]emailBodyRQ emailModel)
        {
            return await _eventRegistrationUserService.ResendOtpAsync(emailModel.Email);
        }

    }
}