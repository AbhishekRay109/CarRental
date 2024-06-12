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
using System.Net.Mail;
using System.Text;
using Assignment.Api.Interfaces.Grades;

namespace Assignment.Api.Controllers
{
    [Route("api/v1/grade")]
    [ApiController]
    public class GradeGradeController : BaseController
    {
        private readonly ApplicationsService _applicationsService;
        private readonly AuthService _authService;
        private readonly IConfiguration _configuration;
        private readonly RolesPermissionService _rolesPermissionService;
        private readonly OrganizationService _organizationService;
        private readonly LoggingService _loggingService;
        private readonly Serilog.Core.Logger logger;
        private readonly GradeGradeService _gradeService;
        private readonly GradeSubjectService _gradeSubjectService;







        public GradeGradeController(GradeSubjectService gradeSubjectService, GradeGradeService gradeService, AuthService authService, IConfiguration configuration, RolesPermissionService rolesPermissionService, OrganizationService organizationservice, Serilog.Core.Logger logger) : base(logger)
        {

            _gradeService = gradeService;
            _authService = authService;
            _configuration = configuration;
            _rolesPermissionService = rolesPermissionService;
            _organizationService = organizationservice;
            this.logger = logger;
            _gradeSubjectService = gradeSubjectService;


        }

        /// <summary>
        /// This API is used to Add Grade Details of a student.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>

        [HttpPost("addgrade")]
        [CustomAuthorize("authorizedTeacher")]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]

        public async Task<ActionResult<GradeGrade>> AddTeacher(GradeGradeRQ request)
        {
            try
            {
                var studdentExists = await _gradeSubjectService.GetSubjectCode(request.SubjectCode);
                if(studdentExists == null)
                {
                    return BadRequest("Subject Not Found");
                }

                var subjectExists = await _gradeService.GetStudentCode(request.StudentCode);    
                if(subjectExists == null)
                {
                    return BadRequest("Student Not Found");
                }
                var createdEvent = await _gradeService.CreateGradeAsync(request);
                return Ok(createdEvent);
            }
            catch (Exception ex)
            {
                LogError($"An error Occurred in CreateEvents API Action :  {ex.Message}", ex);
                return StatusCode(500, $"An error occurred: {ex}");
            }
        }

        /// <summary>
        /// This API will list student's backlog subject if any.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("student/belowthreshold/{studentCode}")]
        [CustomAuthorize("authorizedTeacher")]
        public async Task<IActionResult> GetSubjectsWithScoresBelowThreshold(string studentCode, int threshold = 35)
        {
            try
            {
                var request = new GradeGradeRQ { StudentCode = studentCode };
                var subjectScores = await _gradeService.GetSubjectsWithScoresBelowThresholdAsync(request, threshold);

                return Ok(subjectScores);
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        /// <summary>
        /// This APIis used to send email about the grade, OverallPerformance and backlogs if any.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("send-email/{studentCode}")]
        [CustomAuthorize("authorizedTeacher")]
        public async Task<IActionResult> SendGradeInfoEmail(string studentCode)
        {
            try
            {
                await _gradeService.SendGradeInfoEmailAsync(studentCode);
                return Ok("Email sent successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        /// <summary>
        /// This API willcalculate the students overall performance with respect to their sujects.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("student/performance/{studentCode}")]
        [CustomAuthorize("authorizedTeacher")]
        public async Task<IActionResult> GetStudentPerformance(string studentCode)
        {
            try
            {
                var performanceResponse = await _gradeService.GetStudentPerformanceAsync(studentCode);
                return Ok(performanceResponse);
            }
            catch (Exception ex)
            {
             
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }


        /// <summary>
        /// This API is used to get grade details.
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
                var result = await _gradeService.GetGrade(studentCode);
                if (result == null)
                {
                    return NotFound("Student not found");
                }
                var result1 = new GradeGrade
                {
                    StudentCode = result.StudentCode,
                    SubjectCode = result.SubjectCode,
                    Score = result.Score,
                    GradeLetter = result.GradeLetter

                };
                return Ok(result1);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// This API is used to update grades.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPut("{studentCode}")]
        [CustomAuthorize("authorizedTeacher")]
    
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<IActionResult> UpdateSubject(string studentCode, string subjectCode, GradeGradeUpdateRQ requestModel)
        {
            try
            {

                var updateResult = await _gradeService.UpdateAsync(studentCode, subjectCode, requestModel);

                return Ok(updateResult);


            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// This API is used to delete Grades.
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

                var getTeacher = await _gradeService.DeleteGrade(subjectCode);

                if (getTeacher == null)
                {
                    return NotFound(new { StatusCode = 404, Message = "Grade Not Found" });
                }

                await _gradeService.DeleteGrade(subjectCode);

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
