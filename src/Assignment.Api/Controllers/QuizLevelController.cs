using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models.QuizGame;
using Assignment.Service.Model.ResponseHandler;
using Assignment.Service.Services.QuizGameServices;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Api.Controllers
{
    [ApiController]
    [Route("/levels")]
    public class QuizLevelController : ControllerBase
    {
        private readonly QuizLevelService _levelService;

        public QuizLevelController(QuizLevelService levelService)
        {
            _levelService = levelService;
        }

        /// <summary>
        /// This API is used to fetch all levels.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [CustomAuthorize("quiz-admin")]
        public async Task<IActionResult> GetAllLevelsAsync()
        {
            try
            {
                var levels = await _levelService.GetAllLevelsAsync();
                return Ok(ResponseHandler.HandleSuccess("Levels fetched successfully",levels));
            }
            catch (Exception ex)
            {
                return Ok(ResponseHandler.HandleError<QuizLevel>("BadRequest", ex.Message));
            }
        }
    }
}