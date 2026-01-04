namespace JournalApp.Models
{
    public class Theme
    {
        public int ThemeId { get; set; }
        public string ThemeName { get; set; }
        public bool IsDarkMode { get; set; }
        public int UserId { get; set; }
    }
}
