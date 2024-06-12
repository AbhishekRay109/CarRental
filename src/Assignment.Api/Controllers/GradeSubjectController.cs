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
    [Route("api/v1/subject")]
    [ApiController]
    public class GradeSubjectController : BaseController
    {
        private readonly ApplicationsService _applicationsService;
        private readonly AuthService _authService;
        private readonly IConfiguration _configuration;
        private readonly RolesPermissionService _rolesPermissionService;
        private readonly OrganizationService _organizationService;
        private readonly LoggingService _loggingService;
        private readonly Serilog.Core.Logger logger;
        private readonly GradeSubjectService _subjectService;


        public GradeSubjectController(GradeSubjectService subjectService, AuthService authService, IConfiguration configuration, RolesPermissionService rolesPermissionService, OrganizationService organizationservice, Serilog.Core.Logger logger) : base(logger)
        {

            _subjectService = subjectService;
            _authService = authService;
            _configuration = configuration;
            _rolesPermissionService = rolesPermissionService;
            _organizationService = organizationservice;
            this.logger = logger;

        }



       [HttpPost("GenerateUserToken")]
  public IActionResult GenerateingJwtToken(GradeTokenRQ request)
  {
          string jwtToken = _authService.GenerateJwtTokenGeneric(request.Email, request.Password);
          if (!string.IsNullOrEmpty(jwtToken))
          {
              return Ok(new { Token = jwtToken });
          }
          else
          {
              return NotFound(new { Message = "Invalid Email or password" });
          }
    }
           
        



        /// <summary>
        /// This API is used to Add Subjects.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>

        [HttpPost("addsubject")]
        [CustomAuthorize("authorizedTeacher")]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]

        public async Task<ActionResult<GradeSubject>> AddTeacher(GradeSubjectRQ request)
        {
            try
            {
                

                var createdEvent = await _subjectService.CreateSubjectAsync(request);
                return Ok(createdEvent);
            }
            catch (Exception ex)
            {
                LogError($"An error Occurred in CreateEvents API Action :  {ex.Message}", ex);
                return StatusCode(500, $"An error occurred: {ex}");
            }
        }

        /// <summary>
        /// This API is used to Update Subjects.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPut("{subjectCode}")]
        [CustomAuthorize("authorizedTeacher")]
        [ProducesResponseType(typeof(Events), 200)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<IActionResult> UpdateSubject(string subjectCode, GradeSubjectUpdateRQ requestModel)
        {
            try
            {

                var updateResult = await _subjectService.UpdateAsync(subjectCode, requestModel);

                return Ok(updateResult);
                

            }
            catch (Exception ex)
            {
              
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// This API is used to get Subject details.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>

        [HttpGet("{subjectCode}")]
        [CustomAuthorize("authorizedTeacher")]
        public async Task<IActionResult> GetStudent(string subjectCOde)
        {
            try
            {
                var result = await _subjectService.GetSubjectCode(subjectCOde);
                if (result == null)
                {
                    return NotFound("Student not found");
                }
                var result1 = new GradeSubjectRS
                {
                  
                   SubjectCode = result.SubjectCode,
                   SubjectName = result.SubjectName,

                };
                return Ok(result1);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// This API is used to delete subjects.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>

        [HttpDelete("{subjectCode}")]
        [CustomAuthorize("authorizedTeacher")]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]

        public async Task<IActionResult> DeleteTeacher(string subjectCode)
        {
            try
            {

                var getTeacher = await _subjectService.DeleteSubject(subjectCode);

                if (getTeacher == null)
                {
                    return NotFound(new { StatusCode = 404, Message = "Teacher Not Found" });
                }

                await _subjectService.DeleteSubject(subjectCode);

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
