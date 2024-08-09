
using System.Linq.Expressions;
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

        public async Task<bool> DeleteAllTasksAsync()
        {
            var tasks = await _context.Tasks.ToListAsync();
            _context.Tasks.RemoveRange(tasks);
            var success = await _context.SaveChangesAsync();
            return success > 0;
        }

        public async Task<bool> DeleteTaskAsync(int id)
        {
            int success = 0;
            var task = await _context.Tasks.FindAsync(id);
            if (task is not null)
            {
                _context.Tasks.Remove(task);
                success = await _context.SaveChangesAsync();
            }
            return success > 0;
        }

        public async Task<List<Data.Models.Task>> GetAllTasksAsync(Expression<Func<Data.Models.Task, bool>>? filter = null)
        {
            var tasks = await _context.Tasks.Where(filter ?? ((x) => true)).ToListAsync();
            return tasks;
        }

        public async Task<Data.Models.Task> GetTaskByIdAsync(int? id)
        {
            var task = await _context.Tasks.FindAsync(id);
            return task!;
        }

        public async Task<bool> AddTaskAsync(Data.Models.Task task)
        {
            _context.Tasks.Add(task);
            var success = await _context.SaveChangesAsync();
            return success > 0;
        }

        public async Task<bool> UpdateTaskAsync(Data.Models.Task task)
        {
            _context.Tasks.Update(task);
            var success = await _context.SaveChangesAsync();
            return success > 0;
        }
    }
}
