using Assignment.Infrastructure.AuditLog;
using Assignment.Service.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
using Assignment.Service.Services.Grades;
using IdentityServer4.Services;
using Microsoft.Net.Http.Headers;
using static IdentityModel.OidcConstants;
using Assignment.Service.Model.Grades;
using Amazon.Util.Internal.PlatformServices;
using Assignment.Infrastructure.Repository.Grades;
using Azure.Core;

namespace Assignment.Api.Controllers
{
    [Route("api/v1/teacher")]
    [ApiController]
    public class GradeTeacherController : BaseController
    {
        private readonly ApplicationsService _applicationsService;
        private readonly AuthService _authService;
        private readonly IConfiguration _configuration;
        private readonly RolesPermissionService _rolesPermissionService;
        private readonly OrganizationService _organizationService;
        private readonly LoggingService _loggingService;
        private readonly Serilog.Core.Logger logger;
        private readonly GradeTeacherService _sgradeTeacherService;
      
   



        public GradeTeacherController(GradeTeacherService sGradeTeacherService, AuthService authService, IConfiguration configuration, RolesPermissionService rolesPermissionService, OrganizationService organizationservice, Serilog.Core.Logger logger) : base(logger)
        {
            
            _sgradeTeacherService = sGradeTeacherService;
            _authService = authService;
            _configuration = configuration;
            _rolesPermissionService = rolesPermissionService;
            _organizationService = organizationservice;
            this.logger = logger;

        }

        /// <summary>
        /// This API is used to Add teacher Details.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        
        [HttpPost("addteacher")]
        [CustomAuthorize("authorizedPrincipal")]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]

        public async Task<ActionResult<GradeTeacher>> AddTeacher(GradeTeacherRQ request)
        {
            try
            {
                if (!_sgradeTeacherService.isEmailValid(request.Email))
                {
                    return BadRequest(new { StatusCode = 400, Message = "Invalid Email ID" });
                }

                var email = request.Email;

                if (string.IsNullOrWhiteSpace(email))
                {
                    return BadRequest(new { StatusCode = 400, Message = "Email ID cannot be blank" });
                }

                var createdEvent = await _sgradeTeacherService.CreateTeacherAsync(request);
                return Ok(createdEvent);
            }
            catch (Exception ex)
            {
                LogError($"An error Occurred in CreateEvents API Action :  {ex.Message}", ex);
                return StatusCode(500, $"An error occurred: {ex}");
            }
        }

        /// <summary>
        /// This API is used to update teacher Details.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>

        [HttpPut("{teacherCode}")]
        [CustomAuthorize("authorizedPrincipal")]
     
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<IActionResult> UpdateSubject(string teacherCode,  GradeTeacherUpdateRQ requestModel)
        {
            try
            {

                if (!_sgradeTeacherService.isEmailValid(requestModel.Email))
                {
                    return BadRequest(new { StatusCode = 400, Message = "Invalid Email ID" });
                }

                var email = requestModel.Email;

                if (string.IsNullOrWhiteSpace(email))
                {
                    return BadRequest(new { StatusCode = 400, Message = "Email ID cannot be blank" });
                }

                var updateResult = await _sgradeTeacherService.UpdateAsync(teacherCode, requestModel);

                return Ok(updateResult);


            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// This API is used to get teacher details.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>

        [HttpGet("{teacherCode}")]
        [CustomAuthorize("authorizedPrincipal")]
        public async Task<IActionResult> GetTeacherByName(string teacherCode)
        {
            try
            {
                var result = await _sgradeTeacherService.GetTeacherAsync(teacherCode);
                if (result == null)
                {
                    return NotFound("Teacher not found");
                }
                var result1 = new GradeTeacherRS
                {
                    TeacherId = result.TeacherId,
                    TeacherCode = result.TeacherCode,
                    TeacherName = result.TeacherName,
                    Role = result.Role,
                };
                return Ok(result1);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// This API is used to update teacher details.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>

        [HttpDelete("{teacherCode}")]
        [CustomAuthorize("authorizedPrincipal")]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]

        public async Task<IActionResult> DeleteTeacher(string teacherCode)
        {
            try
            {

                var getTeacher = await _sgradeTeacherService.GetTeacherAsync(teacherCode);

                if (getTeacher == null)
                {
                    return NotFound(new { StatusCode = 404, Message = "Teacher Not Found" });
                }

                await _sgradeTeacherService.DeleteTeacherID(teacherCode);

                return Ok(new { StatusCode = 200, Message = "Deleted Successfully" });


            }
            catch (Exception ex)
            {
                LogError($"An error Occurred in DeleteTeacher API Action :  {ex.Message}", ex);
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }



    }
}
