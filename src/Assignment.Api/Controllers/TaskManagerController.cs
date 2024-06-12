using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models;
using Assignment.Core.Models.TaskManagement;
using Assignment.Service.Model.TaskManagement;
using Assignment.Service.Services;
using Assignment.Service.Services.TaskServices;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskManagerController : BaseController
    {
         private readonly TaskService _taskService;
        private readonly Serilog.Core.Logger logger;
        private readonly AuthService _authService;

        public TaskManagerController(TaskService taskService, AuthService authService, Serilog.Core.Logger logger) : base(logger)
        {
            _taskService = taskService;
            _authService = authService;
            this.logger = logger;
        }
      
        /// <summary>
        /// Creates New Task
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>   
        /// <response code="401"> Unauthorized - User don't have access.</response>
        /// <response code="403"> Forbidden - The User is Forbidden.</response>
        [CustomAuthorize("task-admin")]
        [HttpPost("create")]
        public async Task<AddTaskRQ> CreateTask([FromBody] AddTaskRQ  taskCreationRQ)
        {
            return await _taskService.AddTaskAsync(taskCreationRQ);
            
        }

         /// <summary>
        /// Retrieves the list of tasks.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>   
        /// <response code="401"> Unauthorized - User don't have access.</response>
        /// <response code="403"> Forbidden - The User is Forbidden.</response>
        [CustomAuthorize("task-user")]
        [HttpGet]
        public async Task<IEnumerable<TaskManagerRS>> GetTasks()
        {
            return await _taskService.GetTasksAsync();
        }

        /// <summary>
        /// This endpoint updates already existing tasks by TaskId.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>   
        /// <response code="401"> Unauthorized - User don't have access.</response>
        /// <response code="403"> Forbidden - The User is Forbidden.</response> 
        [CustomAuthorize("task-user")]  
        [HttpPut("update/{taskId}")]
        public async Task<TaskManagerRS> UpdateTask(int taskId, [FromBody] UpdateTaskRQ updateTaskRQ)
        {
            return await _taskService.UpdateTaskAsync(taskId, updateTaskRQ);
        }

        /// <summary>
        /// This endpoint deactivates already existing tasks by TaskId.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>   
        /// <response code="401"> Unauthorized - User don't have access.</response>
        /// <response code="403"> Forbidden - The User is Forbidden.</response>
        [CustomAuthorize("task-admin")]
        [HttpDelete("delete/{taskId}")]
        public async Task<IActionResult> DeleteTask(int taskId)
        {
            var deletedTask = await _taskService.DeleteTaskAsync(taskId);

            if (deletedTask == null)
            {
                return NotFound("Task not found"); 
            }

            return Ok("Task deactivated"); 
        }

        /// <summary>
        /// This endpoint logs time for each task by TaskId.
        /// </summary>
        /// 200 OK - Success.
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>   
        /// <response code="401"> Unauthorized - User don't have access.</response>
        /// <response code="403"> Forbidden - The User is Forbidden.</response>
        [HttpPost("track-time/{taskId}")]
        public async Task<IActionResult> TrackTime(int taskId)
        {
            var timeLogResponse = await _taskService.TrackTimeAsync(taskId);
            return Ok(timeLogResponse);
        }
         
    }
}