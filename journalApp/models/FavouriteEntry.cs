namespace JournalApp.Models
{
    public class FavoriteEntry
    {
        public int FavoriteId { get; set; }
        public int EntryId { get; set; }
        public int UserId { get; set; }
        public DateTime StarredAt { get; set; }
    }
}
