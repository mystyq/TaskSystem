using TaskSystem.Data.Enums;

namespace TaskSystem.Data.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? DateCreated { get; set; }
        private Status? _status = Enums.Status.Staged;
        public Status? Status
        {
            get => _status;
            private set
            {
                _status = value;
            }
        }
        public Priority? Priority { get; set; } = Enums.Priority.None;
        public string? Comment { get; set; }
        public DateTime? TargetCompleteDate { get; set; }
        public DateTime? StartedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public double? EstimateDuration { get; set; }
        public bool? Archived { get; set; } = false;

        public void SetStatus(Status status)
        {
            if (status <= _status)
                return;

            switch(status)
            {
                case Enums.Status.InProgress:
                    this.StartedDate = DateTime.Now;
                    break;
                case Enums.Status.Complete:
                    this.CompletedDate = DateTime.Now;
                    break;
            }

            this.Status = status;
        }
    }
}