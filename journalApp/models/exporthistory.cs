namespace JournalApp.Models
{
    public class ExportHistory
    {
        public int ExportId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ExportedAt { get; set; }
        public string FilePath { get; set; }
        public int UserId { get; set; }
    }
}
