using Assignment.Api.Interfaces.TaskManagement;
using Assignment.Api.Models;
using Assignment.Core.Interfaces;
using Assignment.Core.Models.TaskManagement;
using Assignment.Service.Model.TaskManagement;
using System.Threading.Tasks;

namespace Assignment.Service.Services.TaskServices
{
    public class TaskService
    {
        private readonly IDBTaskRepository _taskRepo;

        public TaskService(IDBTaskRepository taskRepo)
        {
            _taskRepo = taskRepo;
        }

        public async Task<AddTaskRQ> AddTaskAsync(AddTaskRQ addTaskRQ)
        {
            try
            {
                TaskManager task = new TaskManager
                {
                    Title = addTaskRQ.Title,
                    Description = addTaskRQ.Description,
                    DueDate = addTaskRQ.DueDate,
                    IsCompleted = addTaskRQ.IsCompleted,
                    TaskUserId = addTaskRQ.TaskUserId,
                    DependencyId = addTaskRQ.DependencyId
                };

                var rs = await _taskRepo.AddTaskAsync(task);
                return addTaskRQ;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("YOU DONOT HAVE PERMISSION");
            }
        }

        public async Task<IEnumerable<TaskManagerRS>> GetTasksAsync()
        {
            var rs = await _taskRepo.GetTasksAsync();
            var rsList = new List<TaskManagerRS>();
            foreach (var item in rs)
            {
                var temp = new TaskManagerRS()
                {
                    DependencyId = item.DependencyId,
                    Description = item.Description,
                    DueDate = item.DueDate,
                    IsCompleted = item.IsCompleted,
                    TaskId = item.TaskId,
                    TaskUserId = item.TaskUserId,
                    Title = item.Title
                };
                rsList.Add(temp);
            }
            return rsList;
        }
        public async Task<TaskManagerRS> UpdateTaskAsync(int taskId, UpdateTaskRQ updateTaskRQ)
        {
            try
            {
                var info = await _taskRepo.GetTasksAsync(taskId);
                var model = new TaskManager()
                {
                    TaskId = info.TaskId,
                    TaskUserId = updateTaskRQ.TaskUserId,
                    DependencyId = updateTaskRQ.DependencyId,
                    Description = updateTaskRQ.Description,
                    DueDate = updateTaskRQ.DueDate,
                    IsCompleted = updateTaskRQ.IsCompleted,
                    Title = updateTaskRQ.Title
                };
                var rs = await _taskRepo.UpdateTaskManagerTaskAsync(taskId, model);
                var output = new TaskManagerRS()
                {
                    DependencyId = rs.DependencyId,
                    Description = rs.Description,
                    DueDate = rs.DueDate,
                    IsCompleted = rs.IsCompleted,
                    TaskId = rs.TaskId,
                    TaskUserId = rs.TaskUserId,
                    Title = rs.Title
                };
                return output;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("YOU DONOT HAVE PERMISSION");
            }
        }


        public async Task<TaskManager> DeleteTaskAsync(int taskId)
        {
            return await _taskRepo.DeleteTaskManagerTaskAsync(taskId);
        }


        public async Task<TaskTimeLogResponse> TrackTimeAsync(int taskId)
        {
            try
            {
                var taskDetails = await _taskRepo.GetTasksAsync(taskId);

                if (taskDetails == null)
                {
                    throw new ArgumentException("Task not found");
                }

                var existingTimeLog = await _taskRepo.GetTimeLogByTaskIdAsync(taskId);
                DateTime startTime;
                DateTime stopTime;
                int duration = 0;

                if (existingTimeLog == null)
                {

                    startTime = DateTime.UtcNow;
                    stopTime = DateTime.UtcNow; 
                }
                else
                {

                    startTime = existingTimeLog.StartTime;
                    stopTime = DateTime.UtcNow;
                    duration = (int)(stopTime - startTime).TotalMinutes;

                    duration += existingTimeLog.Duration;
                    var timeLogModel1 = new TaskTimeLog
                    {
                        TimeLogId = existingTimeLog.TimeLogId,
                        TaskId = taskId,
                        StartTime = startTime,
                        StopTime = stopTime,
                        Duration = duration,
                    };
                    var result1 = await _taskRepo.TrackTimeAsync(timeLogModel1);
                    var responseModel1 = new TaskTimeLogResponse
                    {
                        TimeLogId = result1.TimeLogId,
                        TaskId = result1.TaskId,
                        StartTime = result1.StartTime,
                        StopTime = result1.StopTime,
                        Duration = result1.Duration,
                        TaskTitle = taskDetails.Title
                    };
                    return responseModel1;

                }

                var timeLogModel = new TaskTimeLog
                {
                    TaskId = taskId,
                    StartTime = startTime,
                    StopTime = stopTime,
                    Duration = duration,
                };

                var result = await _taskRepo.TrackTimeAsync(timeLogModel);
                var responseModel = new TaskTimeLogResponse
                {
                    TimeLogId = result.TimeLogId,
                    TaskId = result.TaskId,
                    StartTime = result.StartTime,
                    StopTime = result.StopTime,
                    Duration = result.Duration,
                    TaskTitle = taskDetails.Title
                };

                return responseModel;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("TASK NOT FOUND ");
            }
        }

    }

}