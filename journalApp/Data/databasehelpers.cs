using System;
using Microsoft.Data.Sqlite;

namespace JournalApp.Data
{
    public class DatabaseHelper
    {
        private string connectionString = "Data Source=journal.db";

        // Get a connection
        public SqliteConnection GetConnection()
        {
            return new SqliteConnection(connectionString);
        }

        // Initialize database and create table if it doesn't exist
        public void InitializeDatabase()
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                string sql = @"
                    CREATE TABLE IF NOT EXISTS JournalEntries (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Title TEXT NOT NULL,
                        Content TEXT,
                        Mood TEXT,
                        Date TEXT
                    );";

                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Example: Add a journal entry
        public void AddEntry(string title, string content, string mood, string date)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO JournalEntries (Title, Content, Mood, Date) VALUES (@title, @content, @mood, @date)";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@content", content);
                    cmd.Parameters.AddWithValue("@mood", mood);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
