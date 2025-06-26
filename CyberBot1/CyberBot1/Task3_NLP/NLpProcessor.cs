using System;
using System.Collections.Generic;

namespace CyberBot1.Task3_NLP

{
    public class NlpProcessor
    {
        // Public method to analyze user input and return an action result
        public static string AnalyzeInput(string input)
        {
            input = input.ToLower();

            // Keywords for adding tasks
            if (input.Contains("add task") || input.Contains("new task") || input.Contains("create task"))
                return "AddTask";

            // Keywords for setting reminders
            if (input.Contains("set reminder") || input.Contains("remind me") || input.Contains("reminder"))
                return "SetReminder";

            // Keywords for quiz
            if (input.Contains("start quiz") || input.Contains("play quiz") || input.Contains("take quiz") || input.Contains("quiz") || input.Contains(" Quiz"))
                return "StartQuiz";

            // Keywords for viewing log
            if (input.Contains("activity log") || input.Contains("what have you done") || input.Contains("show log") || input.Contains("log") || input.Contains("Log") || input.Contains("history"))
                return "ShowLog";

            // Tip commands
            if ( input.Contains("Tips") || input.Contains("tips") || input.Contains("show tips")
              || input.Contains("give tip") || input.Contains("show tips") || input.Contains("tip") || input.Contains("Tip"))
                return "ShowTips";

            // Who/What is CyberBot?
            if (input.Contains("what is cyberbot") || input.Contains("who are you")
                || input.Contains("what is your name") || input.Contains("who is cyberbot"))
                return "WhoIsCyberBot";
            // Chat with the bot (free-form Q&A)
            if (input.Contains("ask cyberbot") || input.Contains("chat") )
                return "OpenChat";

            // Default fallback
            return "Unknown";
        }

        // Optional: Extract task/reminder description
        public static string ExtractReminderDetails(string input)
        {
            // Basic attempt to get text after "remind me to"
            var lower = input.ToLower();
            if (lower.Contains("remind me to"))
            {
                int start = lower.IndexOf("remind me to") + "remind me to".Length;
                return input.Substring(start).Trim();
            }

            return "Reminder";
        }
    }
}
