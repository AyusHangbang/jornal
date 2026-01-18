namespace JournalApp.Models
{
    public class Attachment
    {
        public int AttachmentId { get; set; }
        public int EntryId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public DateTime UploadedAt { get; set; }
    }
}
