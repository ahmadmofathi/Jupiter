namespace Jupiter.APIs.Data.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public bool isDone { get; set; }

        public string assigned_by { get; set; } = string.Empty;

        public string assigned_to { get; set; } = string.Empty;

        public string Deadline { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;

        public int userId { get; set; }
        public User User { get; set; } = null!;
    }
}
