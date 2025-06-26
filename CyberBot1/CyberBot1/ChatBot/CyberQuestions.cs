using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace CyberBot1.ChatBot
{
    public static class CyberQuestions 
    {
        // Store last matched topic between calls
        public static string lastTopic = "";

        public static string GetAnswer(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "⚠️ You didn't type anything. Please ask a question about cybersecurity.";

            // Clean input: remove punctuation; lowercase
            string clean = Regex.Replace(input.ToLower(), "[^a-z0-9 ]", "");
            string[] tokens = clean.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // 1. Sentiment detection: use ConsoleSentimentAnalyzer
            string sentimentReply = SentimentAnalyzer.AnalyzeSentiment(clean);
            if (!string.IsNullOrEmpty(sentimentReply))
            {
                // Return the sentiment response
                return sentimentReply;
            }

            // 2. Handle short/vague input
            if (tokens.Length == 1 && tokens[0].Length < 4)
            {
                return "🤔 I need a bit more detail to help. Try asking about passwords, malware, or safe browsing.";
            }

            // 3. Follow-up based on last known topic
            if (!string.IsNullOrEmpty(lastTopic) &&
                (clean.Contains("more") || clean.Contains("explain") || clean.Contains("confused")))
            {
                // Return advice for lastTopic
                string advice = CyberTopicData.GetAdviceForTopic(lastTopic);
                // Keep lastTopic unchanged or clear? Here keep it for possible further follow-ups
                return advice;
            }

            // 4. Match keywords from input against CyberTopicsData.Keywords
            for (int i = 0; i < CyberTopicData.Keywords.Length; i++)
            {
                foreach (string keyword in CyberTopicData.Keywords[i])
                {
                    // match full token equality or contains? Use tokens array for exact match:
                    if (tokens.Contains(keyword.ToLower()))
                    {
                        // Matched topic
                        lastTopic = CyberTopicData.Topics[i]; // remember matched topic

                        // Pick random response from Responses[i]
                        var responses = CyberTopicData.Responses[i];
                        var rand = new Random();
                        string baseResponse = responses[rand.Next(responses.Length)];

                        // Return that response
                        return baseResponse;
                    }
                }
            }

            // 5. No keyword matched
            lastTopic = ""; // reset
            return "❓ I'm not sure what you mean. Try asking about passwords, phishing, or other online safety topics.";
        }

        /// <summary>
        /// Optional: reset lastTopic, if needed when new conversation begins.
        /// </summary>
        public static void Reset()
        {
            lastTopic = "";
        }
    }
}
