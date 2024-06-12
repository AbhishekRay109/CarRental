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

namespace Assignment.Api.Controllers
{
    [Route("api/v1/class")]
    [ApiController]
    public class GradeClassController : BaseController
    {
        private readonly ApplicationsService _applicationsService;
        private readonly AuthService _authService;
        private readonly IConfiguration _configuration;
        private readonly RolesPermissionService _rolesPermissionService;
        private readonly OrganizationService _organizationService;
        private readonly LoggingService _loggingService;
        private readonly Serilog.Core.Logger logger;
        private readonly GradeClassService _classService;





        public GradeClassController(GradeClassService classService, AuthService authService, IConfiguration configuration, RolesPermissionService rolesPermissionService, OrganizationService organizationservice, Serilog.Core.Logger logger) : base(logger)
        {

            _classService = classService;
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

        [HttpPost("addclass")]
        [CustomAuthorize("authorizedPrincipal")]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]

        public async Task<ActionResult> AddTeacher(GradeClassRQ request)
        {
            try
            {
                var teacherExists = await _classService.GetTeacher(request.TeacherID);

                if (teacherExists == null)
                {
                    return BadRequest("Teacher Does Not Exist");
                }

                var createdEvent = await _classService.CreateClassAsync(request);
                return Ok(createdEvent);
            }
            catch (Exception ex)
            {
                LogError($"An error Occurred in CreateEvents API Action :  {ex.Message}", ex);
                return StatusCode(500, $"An error occurred: {ex}");
            }
        }


        /// <summary>
        /// This API is used to Add Update Class Details.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPut("{classID}")]
        [CustomAuthorize("authorizedPrincipal")]
  
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<IActionResult> UpdateClass(int classID, GradeClassUpdateRQ requestModel)
        {
            try
            {
             

                var updateResult = await _classService.UpdateAsync(classID, requestModel);

                return Ok(updateResult);


            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

       
        /// <summary>
        /// This API is used to get Class details.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>

        [HttpGet("{classId}")]
        [CustomAuthorize("authorizedPrincipal")]
        public async Task<IActionResult> GetTeacherByName(int classId)
        {
            try
            {
                var result = await _classService.GetTeacherID(classId);
                if (result == null)
                {
                    return NotFound("Teacher not found");
                }
                var result1 = new GradeClassRS
                {
                    ClassId = result.ClassId,
                    TeacherID = result.TeacherId,
                    Class = result.Class
                };
                return Ok(result1);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// This API is used to Delete Class details.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>

        [HttpDelete("{classID}")]
        [CustomAuthorize("authorizedPrincipal")]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]

        public async Task<IActionResult> DeleteTeacher(int classID)
        {
            try
            {

                var getTeacher = await _classService.DeleteTeacherID(classID);

                if (getTeacher == null)
                {
                    return NotFound(new { StatusCode = 404, Message = "Teacher Not Found" });
                }

                await _classService.DeleteTeacherID(classID);

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
