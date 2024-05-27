using Api.Models;

namespace Api.Repositories;

public interface ITaskRepository
{
    Task<TaskItem> GetTaskByIdAsync(int id);
    Task<IEnumerable<TaskItem>> GetTasksByUserIdAsync(int userId);
    Task AddTaskAsync(TaskItem task);
    Task RemoveTaskAsync(TaskItem task);
}