using System.Linq.Expressions;

namespace TaskSystem.Services
{
    public interface ITaskService
    {
        Task<List<Data.Models.Task>> GetAllTasksAsync(Expression<Func<Data.Models.Task, bool>>? filter = null);

        Task<Data.Models.Task> GetTaskByIdAsync(int? id);

        Task<bool> AddTaskAsync(Data.Models.Task task);

        Task<bool> UpdateTaskAsync(Data.Models.Task task);

        Task<bool> DeleteTaskAsync(int id);

        Task<bool> DeleteAllTasksAsync();
    }
}
