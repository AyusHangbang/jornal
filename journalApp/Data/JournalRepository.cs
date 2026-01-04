using JournalApp.Models;
using Microsoft.Data.Sqlite;
using System.Text.Json;

namespace JournalApp.Data
{
    public class JournalRepository
    {
        public void Save(Journal j)
        {
            using var con = DatabaseHelpers.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText =
            """
            INSERT INTO Journals
            VALUES (NULL,@date,@title,@content,@pm,@sm,@cat,@tags,@created,@updated)
            ON CONFLICT(EntryDate) DO UPDATE SET
            Title=@title, Content=@content, PrimaryMood=@pm,
            SecondaryMoods=@sm, Category=@cat, Tags=@tags,
            UpdatedAt=@updated;
            """;

            cmd.Parameters.AddWithValue("@date", j.EntryDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@title", j.Title);
            cmd.Parameters.AddWithValue("@content", j.Content);
            cmd.Parameters.AddWithValue("@pm", (int)j.PrimaryMood);
            cmd.Parameters.AddWithValue("@sm", JsonSerializer.Serialize(j.SecondaryMoods));
            cmd.Parameters.AddWithValue("@cat", j.Category);
            cmd.Parameters.AddWithValue("@tags", JsonSerializer.Serialize(j.Tags));
            cmd.Parameters.AddWithValue("@created", j.CreatedAt.ToString("o"));
            cmd.Parameters.AddWithValue("@updated", DateTime.Now.ToString("o"));

            cmd.ExecuteNonQuery();
        }

        public void Delete(DateTime date)
        {
            using var con = DatabaseHelpers.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM Journals WHERE EntryDate=@d";
            cmd.Parameters.AddWithValue("@d", date.ToString("yyyy-MM-dd"));
            cmd.ExecuteNonQuery();
        }

        public List<Journal> GetAll()
        {
            var list = new List<Journal>();
            using var con = DatabaseHelpers.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Journals";

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(new Journal
                {
                    EntryDate = DateTime.Parse(r["EntryDate"].ToString()!),
                    Title = r["Title"].ToString()!,
                    Content = r["Content"].ToString()!,
                    PrimaryMood = (Enums.Mood)Convert.ToInt32(r["PrimaryMood"]),
                    Tags = JsonSerializer.Deserialize<List<string>>(r["Tags"].ToString()!) ?? new()
                });
            }
            return list;
        }
    }
}
