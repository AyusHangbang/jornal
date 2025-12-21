using System;

namespace JournalApp.Models
{
    public class Journal
    {
        public int Id { get; set; }              // Primary key
        public string Title { get; set; }        // Journal entry title
        public string Content { get; set; }      // Main text content
        public DateTime CreatedAt { get; set; }  // Entry creation timestamp

        public Journal()
        {
            CreatedAt = DateTime.Now; // Automatically set creation time
        }
    }
}
