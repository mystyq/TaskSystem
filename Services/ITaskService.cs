using System.Linq.Expressions;

namespace TaskSystem.Services
{
    public interface ITaskService
    {
        Task<List<Data.Models.Task>> GetAllTasksAsync(Expression<Func<Data.Models.Task, bool>>? filter = null);

        Task<Data.Models.Task> GetTaskByIdAsync(int? id);

        Task AddTaskAsync(Data.Models.Task task);

        Task UpdateTaskAsync(Data.Models.Task task);

        Task DeleteTaskAsync(int id);

        Task DeleteAllTasksAsync();
    }
}
