namespace JournalApp.Services
{
    public class StreakService
    {
        public int Current(List<DateTime> dates)
        {
            int s = 0;
            var d = DateTime.Today;
            while (dates.Contains(d)) { s++; d = d.AddDays(-1); }
            return s;
        }

        public int Longest(List<DateTime> dates)
        {
            dates.Sort();
            int max = 1, cur = 1;
            for (int i = 1; i < dates.Count; i++)
            {
                if ((dates[i] - dates[i - 1]).Days == 1) cur++;
                else cur = 1;
                max = Math.Max(max, cur);
            }
            return max;
        }
    }
}
