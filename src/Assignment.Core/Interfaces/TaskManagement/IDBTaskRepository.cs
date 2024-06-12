using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models;

namespace Assignment.Api.Interfaces.TaskManagement
{
    public interface IDBTaskRepository
    {
        public Task<TaskManager> AddTaskAsync(TaskManager taskManager);
        public Task<IEnumerable<TaskManager>> GetTasksAsync();
        public Task<TaskManager> UpdateTaskManagerTaskAsync(int taskId, TaskManager updateTaskRQ);
        public Task<TaskManager> DeleteTaskManagerTaskAsync(int taskId);
        public Task<TaskManager> GetTasksAsync(int taskId);
        public Task<TaskTimeLog> GetTimeLogByTaskIdAsync(int taskId);
         public Task<TaskTimeLog> TrackTimeAsync(TaskTimeLog timeLogModel);
    }
}