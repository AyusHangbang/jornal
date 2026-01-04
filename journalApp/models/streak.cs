namespace JournalApp.Models
{
    public class Streak
    {
        public int StreakId { get; set; }
        public int CurrentStreak { get; set; }
        public int LongestStreak { get; set; }
        public int MissedDays { get; set; }
        public int UserId { get; set; }
    }
}
