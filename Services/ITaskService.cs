namespace TaskSystem.Services
{
    public interface ITaskService
    {
        Task<List<Data.Models.Task>> GetAllTasksAsync();

        Task<Data.Models.Task> GetTaskByIdAsync(int id);

        Task AddTaskAsync(Data.Models.Task task);

        Task UpdateTaskAsync(Data.Models.Task task);

        Task DeleteTaskAsync(int id);

        Task DeleteAllTasksAsync();
    }
}
