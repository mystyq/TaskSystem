using System.ComponentModel.DataAnnotations.Schema;
using TaskSystem.Data.Enums;

namespace TaskSystem.Data.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? DateCreated { get; set; }
        private Status _status = Status.Staged;
        public Status Status
        {
            get => _status;
            private set
            {
                _status = value;
            }
        }
        public Priority Priority { get; set; } = Priority.None;
        public string? Comment { get; set; }
        public DateTime? TargetCompleteDate { get; set; }
        public DateTime? StartedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public double EstimateDuration { get; set; }
        [NotMapped]
        public TimeSpan EstimateTimeSpan { get => TimeSpan.FromMinutes(this.EstimateDuration); }
        private int _estimateHours = 0;
        [NotMapped]
        public int EstimateHours
        {
            get
            {
                var timeSpan = TimeSpan.FromMinutes(this.EstimateDuration);
                _estimateHours = (int)timeSpan.TotalHours;
                return _estimateHours;
            }
            set
            {
                _estimateHours = value;
                CalculateEstimate();
            }
        }
        private int _estimateMinutes = 0;
        [NotMapped]
        public int EstimateMinutes
        {
            get
            {
                var timeSpan = TimeSpan.FromMinutes(this.EstimateDuration);
                _estimateMinutes = timeSpan.Minutes;
                return _estimateMinutes;
            }
            set
            {
                _estimateMinutes = value;
                CalculateEstimate();
            }
        }
        public bool? Archived { get; set; } = false;

        public void SetStatus(Status status)
        {
            if (status <= _status)
                return;

            switch(status)
            {
                case Status.InProgress:
                    this.StartedDate = DateTime.Now;
                    break;
                case Status.Complete:
                    this.CompletedDate = DateTime.Now;
                    break;
            }

            this.Status = status;
        }

        private void CalculateEstimate()
        {
            this.EstimateDuration = (_estimateHours*60) + _estimateMinutes;
        }
    }
}