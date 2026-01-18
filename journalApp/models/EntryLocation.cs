namespace JournalApp.Models
{
    public class EntryLocation
    {
        public int LocationId { get; set; }
        public int EntryId { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Coordinates { get; set; }
    }
}
