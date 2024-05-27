using Api.Models;
using Api.Repositories;

namespace Api.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _taskRepository;

    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task<TaskItem> GetTaskByIdAsync(int id)
    {
        return await _taskRepository.GetTaskByIdAsync(id);
    }

    public async Task<IEnumerable<TaskItem>> GetTasksByUserIdAsync(int userId)
    {
        return await _taskRepository.GetTasksByUserIdAsync(userId);
    }

    public async Task AddTaskAsync(TaskItem task)
    {
        await _taskRepository.AddTaskAsync(task);
    }

    public async Task RemoveTaskAsync(int id)
    {
        var task = await _taskRepository.GetTaskByIdAsync(id);
        if (task != null)
        {
            await _taskRepository.RemoveTaskAsync(task);
        }
    }
}