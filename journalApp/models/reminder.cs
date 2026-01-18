namespace JournalApp.Models
{
    public class Reminder
    {
        public int ReminderId { get; set; }
        public TimeSpan ReminderTime { get; set; }
        public bool IsEnabled { get; set; }
        public int UserId { get; set; }
        namespace JournalApp.Models
{
    public class Reminder
    {
        public int ReminderId { get; set; }
        public int UserId { get; set; }
        public DateTime ReminderTime { get; set; }
        public string Message { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

    }




