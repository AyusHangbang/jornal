public Dictionary<string,int> MoodStats(List<Journal> j) =>
    j.GroupBy(e => e.PrimaryMood.ToString())
     .ToDictionary(g => g.Key, g => g.Count());
