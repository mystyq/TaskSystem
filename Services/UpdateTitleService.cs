namespace TaskSystem.Services
{
    public class UpdateTitleService
    {
        public event EventHandler<UpdateTitleEventArgs>? UpdateTitleChanged;

        public void UpdateTitle(string title)
        {
            UpdateTitleChanged?.Invoke(this, new UpdateTitleEventArgs
            {
                Title = title
            });
        }

        public class UpdateTitleEventArgs : EventArgs
        {
            public string? Title { get; set; }
        }
    }
}

