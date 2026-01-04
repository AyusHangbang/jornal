namespace JournalApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string PinHash { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
