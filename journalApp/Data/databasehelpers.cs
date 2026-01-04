using Microsoft.Data.Sqlite;

namespace JournalApp.Data
{
    public static class DatabaseHelpers
    {
        private const string Db = "journal.db";

        public static SqliteConnection GetConnection()
            => new SqliteConnection($"Data Source={Db}");

        public static void Initialize()
        {
            using var con = GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText =
            """
            CREATE TABLE IF NOT EXISTS Journals (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                EntryDate TEXT UNIQUE,
                Title TEXT,
                Content TEXT,
                PrimaryMood INTEGER,
                SecondaryMoods TEXT,
                Category TEXT,
                Tags TEXT,
                CreatedAt TEXT,
                UpdatedAt TEXT
            );
            """;
            cmd.ExecuteNonQuery();
        }
    }
}
