namespace JournalApp.Models
{
    public class Reminder
    {
        public int ReminderId { get; set; }
        public TimeSpan ReminderTime { get; set; }
        public bool IsEnabled { get; set; }
        public int UserId { get; set; }
    }
}
