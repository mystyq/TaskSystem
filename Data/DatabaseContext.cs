using Microsoft.EntityFrameworkCore;

namespace TaskSystem.Data
{
    public class DatabaseContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        public DatabaseContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_configuration.GetConnectionString("tasks.db"));
        }

        public DbSet<Models.Task> Tasks { get; set; }
    }
}