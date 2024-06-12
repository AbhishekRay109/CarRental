using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models;
using Assignment.Service.Model.EventRegistration;
using Assignment.Service.Services;
using Assignment.Service.Services.EventRegistrationServices;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Api.Controllers
{
    [Route("event-registration")]
    [ApiController]
    public class EventRegistrationController : BaseController
    {
        private readonly ILogger<EventRegistrationUsersController> _logger;
        private readonly EventRegistrationService _eventRegistrationService;
        private readonly AuthService _authService;
        private readonly Serilog.Core.Logger logger;
        public EventRegistrationController(AuthService authService, EventRegistrationService eventRegistrationService, Serilog.Core.Logger logger) : base(logger)
        {
            _eventRegistrationService = eventRegistrationService;
            _authService = authService;
            this.logger = logger;
        }

        /// <summary>
        /// This endpoint is used to register for a event and get the pass of that event.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [CustomAuthorize("audience")]
        [HttpPost()]
        public async Task<EventRegistrationRS> RegisterForEvent([FromForm] EventRegistrationRQ modelRQ)
        {
            string authorizationHeader = Request.Headers["Authorization"].ToString();
            string token = authorizationHeader.Replace("Bearer ", "");
            token = await _authService.DecryptJwt(token);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
            string userEmail = tokenClaim.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value;
            return await _eventRegistrationService.RegisterForEventAsync(modelRQ, userEmail);
        }
        /// <summary>
        /// This endpoint is used to get the registered event list.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [CustomAuthorize("audience")]
        [HttpGet()]
        public async Task<IEnumerable<EventRegistrationRS>> GetRegisterEvent()
        {
            string authorizationHeader = Request.Headers["Authorization"].ToString();
            string token = authorizationHeader.Replace("Bearer ", "");
            token = await _authService.DecryptJwt(token);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
            string userEmail = tokenClaim.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value;
            return await _eventRegistrationService.GetRegisteredEventAsync(userEmail);
        }
        /// <summary>
        /// This endpoint is used to get the registered event list.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [CustomAuthorize("audience")]
        [HttpGet("pass/{eventRegistrationId}")]
        public async Task<IActionResult> GetPass(int eventRegistrationId)
        {
            string authorizationHeader = Request.Headers["Authorization"].ToString();
            string token = authorizationHeader.Replace("Bearer ", "");
            token = await _authService.DecryptJwt(token);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
            string userEmail = tokenClaim.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value;
            var rs = await _eventRegistrationService.GetPassByEventRegisteredId(eventRegistrationId, userEmail);
            return File(rs, "image/png", "QR.png");
        }

        /// <summary>
        /// This endpoint is used to get the details in the QR code.This is a open API.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>

        [HttpPost("decode-pass")]
        public async Task<IActionResult> DecodePass([FromForm] EventRgistrationPassQrRQ File)
        {
            string authorizationHeader = Request.Headers["Authorization"].ToString();
            string token = authorizationHeader.Replace("Bearer ", "");
            token = await _authService.DecryptJwt(token);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
            string userEmail = tokenClaim.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value;
            byte[] ImageBytes = null;
            if (File != null)
            {
                using (var stream = File.Image.OpenReadStream())
                {
                    using (var memoryStream = new System.IO.MemoryStream())
                    {
                        await stream.CopyToAsync(memoryStream);
                        ImageBytes = memoryStream.ToArray();
                    }
                }
            }
            var rs = _eventRegistrationService.DecodeQRCode(ImageBytes);
            return Ok(rs);
        }

        /// <summary>
        /// This endpoint is used by organizer to validate the pass of the user.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [CustomAuthorize("organizer")]
        [HttpPost("validate-pass")]
        public async Task<EventRegistrationPass> ValidatePass([FromForm] EventRgistrationPassQrRQ File)
        {
            string authorizationHeader = Request.Headers["Authorization"].ToString();
            string token = authorizationHeader.Replace("Bearer ", "");
            token = await _authService.DecryptJwt(token);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
            string userEmail = tokenClaim.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value;
            var rs = await _eventRegistrationService.ValidatePass(File,userEmail);
            return rs;
        }

    }
}