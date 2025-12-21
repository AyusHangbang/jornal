using Microsoft.Data.Sqlite;
using System;
using System.Windows;

namespace JournalApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            

            // Initialize SQLite database
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            // Path: C:\Users\Ripple\Desktop\My Journal\journalApp\journal.db
            string dbPath = "journal.db";

            using var connection = new SqliteConnection($"Data Source={dbPath}");
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS JournalEntries (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Title TEXT NOT NULL,
                    Content TEXT,
                    CreatedAt TEXT NOT NULL
                );";
            command.ExecuteNonQuery();
        }
    }
}
