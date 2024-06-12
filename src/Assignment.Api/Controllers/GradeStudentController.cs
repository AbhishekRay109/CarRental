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
using Amazon.Runtime.Internal;
using Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations;

namespace Assignment.Api.Controllers
{
    [Route("api/v1/student")]
    [ApiController]
    public class GradeStudentController : BaseController
    {
        private readonly ApplicationsService _applicationsService;
        private readonly AuthService _authService;
        private readonly IConfiguration _configuration;
        private readonly RolesPermissionService _rolesPermissionService;
        private readonly OrganizationService _organizationService;
        private readonly LoggingService _loggingService;
        private readonly Serilog.Core.Logger logger;
        private readonly GradeStudentService _studentService;
        private readonly GradeClassService _gradeClassService;
        






        public GradeStudentController(GradeClassService gradeClassService, GradeStudentService classService, AuthService authService, IConfiguration configuration, RolesPermissionService rolesPermissionService, OrganizationService organizationservice, Serilog.Core.Logger logger) : base(logger)
        {
            _gradeClassService = gradeClassService;
            _studentService = classService;
            _authService = authService;
            _configuration = configuration;
            _rolesPermissionService = rolesPermissionService;
            _organizationService = organizationservice;
            this.logger = logger;

        }

        /// <summary>
        /// This API is used to Add Student Details.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>

        [HttpPost("addstudent")]
        [CustomAuthorize("authorizedTeacher")]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]

        public async Task<ActionResult<GradeStudent>> AddStudent(GradeStudentRQ request)
        {
            try
            {
                var classExists = await _gradeClassService.GetClassName(request.Class);

                if(classExists == null)
                {
                    return BadRequest("Class Does Not Exist");
                }

                var getTeacher = await _studentService.GetStudentCode(request.StudentCode);

                if (getTeacher !=null)
                {
                    return NotFound(new { StatusCode = 404, Message = "StudentCode Already Exists" });
                }

                var email = request.Email;

                if (string.IsNullOrWhiteSpace(email))
                {
                    return BadRequest(new { StatusCode = 400, Message = "Email ID cannot be blank" });
                }

                if (!_studentService.isEmailValid(request.Email))
                {
                    return BadRequest(new { StatusCode = 400, Message = "Invalid Email ID" });
                }

                

               
                var createdEvent = await _studentService.CreateStudentAsync(request);
                return Ok(createdEvent);
            }
            catch (Exception ex)
            {
                LogError($"An error Occurred in CreateEvents API Action :  {ex.Message}", ex);
                return StatusCode(500, $"An error occurred: {ex}");
            }
        }

        /// <summary>
        /// This API is used to Add get Details.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>

        [HttpGet("{studentCode}")]
        [CustomAuthorize("authorizedStudent")]
        public async Task<IActionResult> GetStudent(string studentCode)
        {
            try
            {
                var result = await _studentService.GetStudentCode(studentCode);
                if (result == null)
                {
                    return NotFound("Student not found");
                }
                var result1 = new GradeStudentRS
                {
                    StudentCode = result.StudentCode,
                    StudentFname = result.StudentFname,
                    StudentLname = result.StudentLname,
                    Dob = result.Dob,
                    Email = result.Email,
                    Gender = result.Gender,
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
        /// This API is used to Update Student Details.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPut("{studentCode}")]
        [CustomAuthorize("authorizedTeacher")]

        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<IActionResult> UpdateStudent(string studentCode, GradeStudentUpdateRQ requestModel)
        {
            try
            {

                if (!_studentService.isEmailValid(requestModel.Email))
                {
                    return BadRequest(new { StatusCode = 400, Message = "Invalid Email ID" });
                }



                var email = requestModel.Email;

                if (string.IsNullOrWhiteSpace(email))
                {
                    return BadRequest(new { StatusCode = 400, Message = "Email ID cannot be blank" });
                }


                var getStudent = await _studentService.GetStudentCode(studentCode);

                if (getStudent == null)
                {
                    return NotFound(new { StatusCode = 404, Message = "StudentCode Already Exists" });
                }

                var updateResult = await _studentService.UpdateAsync(studentCode, requestModel);

                return Ok(updateResult);


            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// This API is used to delete studentdetails.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>

        [HttpDelete("{studentCode}")]
        [CustomAuthorize("authorizedTeacher")]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]

        public async Task<IActionResult> DeleteTeacher(string studentCode)
        {
            try
            {

                var getTeacher = await _studentService.GetStudentCode(studentCode);

                if (getTeacher == null)
                {
                    return NotFound(new { StatusCode = 404, Message = "Student Not Found" });
                }

                await _studentService.DeleteStudentCode(studentCode);

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
