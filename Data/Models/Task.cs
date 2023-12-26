using TaskSystem.Data.Enums;

namespace TaskSystem.Data.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? DateCreated { get; set; }
        public Status? Status { get; set; }
    }
}