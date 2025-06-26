using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBot1.Logging
{
    // This class provides a simple activity log to track important events in the application.
    public static class ActivityLog
    {
        // Store up to 50 entries; we’ll display the last 5–10.
        private static readonly List<string> entries = new List<string>();

        // Call this whenever something important happens
        public static void Add(string entry)
        {
            // Timestamp + description
            entries.Add($"{DateTime.Now:HH:mm} — {entry}");

            // Keep list from growing unbounded
            if (entries.Count > 50)
                entries.RemoveAt(0);
        }

        // Retrieve the last N entries (default 10)
        public static IList<string> GetRecent(int maxItems = 10)
        {
            int skip = Math.Max(0, entries.Count - maxItems);
            return entries.GetRange(skip, entries.Count - skip);
        }

        // Or retrieve all (if you add a “show more” feature later)
        public static IList<string> GetAll() => new List<string>(entries);
    }
}
