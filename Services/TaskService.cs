
using Microsoft.EntityFrameworkCore;
using TaskSystem.Data;

namespace TaskSystem.Services
{
    public class TaskService : ITaskService
    {
        private readonly DatabaseContext _context;

        public TaskService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task DeleteAllTasksAsync()
        {
            var tasks = await _context.Tasks.ToListAsync();
            _context.Tasks.RemoveRange(tasks);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTaskAsync(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task is not null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Data.Models.Task>> GetAllTasksAsync()
        {
            var tasks = await _context.Tasks.ToListAsync();
            return tasks;
        }

        public async Task<Data.Models.Task> GetTaskByIdAsync(int? id)
        {
            var task = await _context.Tasks.FindAsync(id);
            return task;
        }

        public async Task AddTaskAsync(Data.Models.Task task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTaskAsync(Data.Models.Task task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
        }
    }
}
