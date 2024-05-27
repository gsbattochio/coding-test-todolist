using Api.Models;

namespace Api.Services;

public interface ITaskService
{
    Task<TaskItem> GetTaskByIdAsync(int id);
    Task<IEnumerable<TaskItem>> GetTasksByUserIdAsync(int userId);
    Task AddTaskAsync(TaskItem task);
    Task RemoveTaskAsync(int id);
}