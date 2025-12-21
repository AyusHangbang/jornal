using Microsoft.Data.Sqlite;
using System;
using System.Windows;

namespace JournalApp
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            // Initialize SQLite database
            InitializeDatabase();

            // Start WPF application
            var app = new Application();
            var mainWindow = new MainWindow();
            app.Run(mainWindow);
        }

        private static void InitializeDatabase()
        {
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

