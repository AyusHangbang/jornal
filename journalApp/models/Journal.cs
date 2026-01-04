using JournalApp.Enums;

namespace JournalApp.Models
{
    public class Journal
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }

        public string Title { get; set; } = "";
        public string Content { get; set; } = "";

        public Mood PrimaryMood { get; set; }
        public List<Mood> SecondaryMoods { get; set; } = new();

        public string Category { get; set; } = "";
        public List<string> Tags { get; set; } = new();

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
