namespace JournalApp.Models
{
    public class SentimentScore
    {
        public int SentimentId { get; set; }
        public int EntryId { get; set; }
        public double PositiveScore { get; set; }
        public double NeutralScore { get; set; }
        public double NegativeScore { get; set; }
        public DateTime CalculatedAt { get; set; }
    }
}
