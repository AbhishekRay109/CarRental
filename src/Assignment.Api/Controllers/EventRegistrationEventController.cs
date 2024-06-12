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
    [Route("event-registration-event")]
    [ApiController]
    public class EventRegistrationEventController : BaseController
    {
        private readonly ILogger<EventRegistrationUsersController> _logger;
        private readonly EventRegistrationEventService _eventRegistrationEventService;
        private readonly AuthService _authService;
        private readonly Serilog.Core.Logger logger;
        public EventRegistrationEventController(AuthService authService, EventRegistrationEventService eventRegistrationEventService, Serilog.Core.Logger logger) : base(logger)
        {
            _eventRegistrationEventService = eventRegistrationEventService;
            _authService = authService;
            this.logger = logger;
        }

        /// <summary>
        /// This endpoint is used for adding new event By organizer.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [CustomAuthorize("organizer")]
        [HttpPost()]
        public async Task<EventRegistrationEventRS> AddEvent([FromForm] EventRegistrationEventRQ modelRQ)
        {
            string authorizationHeader = Request.Headers["Authorization"].ToString();
            string token = authorizationHeader.Replace("Bearer ", "");
            token = await _authService.DecryptJwt(token);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
            string userEmail = tokenClaim.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value;
            return await _eventRegistrationEventService.AddEventAsync(modelRQ, userEmail);
        }
        /// <summary>
        /// This endpoint is used for updating event details By organizer.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [CustomAuthorize("organizer")]
        [HttpPut("{eventCode}")]
        public async Task<EventRegistrationEventRS> UpdateEvent([FromForm] EventRegistrationUpdateEventRQ modelRQ, [FromRoute] string eventCode)
        {
            string authorizationHeader = Request.Headers["Authorization"].ToString();
            string token = authorizationHeader.Replace("Bearer ", "");
            token = await _authService.DecryptJwt(token);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
            string userEmail = tokenClaim.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value;
            return await _eventRegistrationEventService.UpdateEventAsync(modelRQ, eventCode, userEmail);
        }

        /// <summary>
        /// This endpoint is used for deactivating event By organizer.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [CustomAuthorize("organizer")]
        [HttpDelete("{eventCode}")]
        public async Task<EventRegistrationEventRS> DeactivateEvent([FromRoute] string eventCode)
        {
            string authorizationHeader = Request.Headers["Authorization"].ToString();
            string token = authorizationHeader.Replace("Bearer ", "");
            token = await _authService.DecryptJwt(token);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
            string userEmail = tokenClaim.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value;
            return await _eventRegistrationEventService.DeactivateEventAsync(eventCode, userEmail);
        }
        /// <summary>
        /// This endpoint is used for Reactivating event By organizer.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [CustomAuthorize("organizer")]
        [HttpPut("re-activate/{eventCode}")]
        public async Task<EventRegistrationEventRS> ReactivateEvent([FromRoute] string eventCode)
        {
            string authorizationHeader = Request.Headers["Authorization"].ToString();
            string token = authorizationHeader.Replace("Bearer ", "");
            token = await _authService.DecryptJwt(token);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenClaim = tokenHandler.ReadToken(token) as JwtSecurityToken;
            string userEmail = tokenClaim.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value;
            return await _eventRegistrationEventService.ReActivateEventAsync(eventCode, userEmail);
        }

        /// <summary>
        /// This endpoint is used for getting information of all the events in DB.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet()]
        public async Task<IEnumerable<EventRegistrationEventRS>> GetEvent(
            [FromQuery] DateTime from,
            [FromQuery] DateTime to,
            [FromQuery] string eventCode,
            [FromQuery] string eventName,
            [FromQuery] string venue
            )
        {
            return await _eventRegistrationEventService.GetEventAsync(from, to, eventName, venue, eventCode);
        }

        /// <summary>
        /// This endpoint is used for Reactivating event By organizer.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("{eventCode}/poster")]
        public async Task<IActionResult> GetPostersEvent([FromRoute] string eventCode)
        {
            var rs =await _eventRegistrationEventService.GetEventPosterAsync(eventCode);
            return File(rs, "image/jpeg");
        }


    }
}