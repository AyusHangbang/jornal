namespace JournalApp.Models
{
    public class Analytics
    {
        public int AnalyticsId { get; set; }
        public int TotalEntries { get; set; }
        public string MostFrequentMood { get; set; }
        public int AvgWordCount { get; set; }
        public DateTime GeneratedAt { get; set; }
        public int UserId { get; set; }
    }
}
