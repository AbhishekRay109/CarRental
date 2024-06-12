using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.TaskManagement;
using Assignment.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Infrastructure.Repository.TaskManager
{
    public class TaskRepository : IDBTaskRepository
    {
        private readonly RaidenDBContext _dbContext;

        public TaskRepository(RaidenDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Api.Models.TaskManager> AddTaskAsync(Api.Models.TaskManager taskManager)
        {
            _dbContext.TaskManager.Add(taskManager);
            await _dbContext.SaveChangesAsync();
            return taskManager;
        }

        public async Task<IEnumerable<Api.Models.TaskManager>> GetTasksAsync()
        {
            return await _dbContext.TaskManager.ToListAsync();
        }


        public async Task<Api.Models.TaskManager> UpdateTaskManagerTaskAsync(int taskId, Api.Models.TaskManager updateTaskRQ)
        {
            var existingTask = await _dbContext.TaskManager.FindAsync(taskId);

            if (existingTask == null)
            {
                throw new ArgumentException("Task not found");
            }
            existingTask.Title = updateTaskRQ.Title;
            existingTask.Description = updateTaskRQ.Description;
            existingTask.DueDate = updateTaskRQ.DueDate;
            existingTask.IsCompleted = updateTaskRQ.IsCompleted;
            existingTask.TaskUserId = updateTaskRQ.TaskUserId;
            existingTask.DependencyId = updateTaskRQ.DependencyId;
            _dbContext.TaskManager.Update(existingTask);
            await _dbContext.SaveChangesAsync();

            return existingTask;
        }

        public async Task<Api.Models.TaskManager> DeleteTaskManagerTaskAsync(int taskId)
        {
            var taskToDelete = await _dbContext.TaskManager.FirstOrDefaultAsync(e => e.TaskId == taskId);

            if (taskToDelete == null)
            {
                return null;
            }

            _dbContext.TaskManager.Remove(taskToDelete);
            await _dbContext.SaveChangesAsync();

            return taskToDelete;
        }
        public async Task<Api.Models.TaskManager> GetTasksAsync(int taskId)
        {
            return await _dbContext.TaskManager.FirstOrDefaultAsync(e => e.TaskId == taskId);
        }

        public async Task<TaskTimeLog> GetTimeLogByTaskIdAsync(int taskId)
        {
            return await _dbContext.TaskTimeLog.FirstOrDefaultAsync(e => e.TaskId == taskId);
        }

        public async Task<TaskTimeLog> TrackTimeAsync(TaskTimeLog timeLogModel)
        {
            _dbContext.TaskTimeLog.Update(timeLogModel);
            await _dbContext.SaveChangesAsync();
            return timeLogModel;
        }
    }
}