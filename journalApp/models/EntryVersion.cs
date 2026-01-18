namespace JournalApp.Models
{
    public class EntryVersion
    {
        public int VersionId { get; set; }
        public int EntryId { get; set; }
        public string ContentSnapshot { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
