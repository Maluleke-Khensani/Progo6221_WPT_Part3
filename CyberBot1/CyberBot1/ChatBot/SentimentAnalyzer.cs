using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBot1.ChatBot
{
    public static class SentimentAnalyzer
    {
        
            // Map sentiment keywords to responses (with follow-up prompts included)
            private static readonly Dictionary<string, string> sentimentResponses = new Dictionary<string, string>()
        {
            // Negative emotions
            { "confused", "😕 It's okay to be confused. I’ll try to explain it more clearly.\n💬 Could you tell me which part you’re struggling with — passwords, phishing, or something else?" },
            { "lost", "😕 It's easy to feel lost with tech stuff. Let’s break it down together.\n💬 What part would you like help with?" },
            { "do not understand", "😕 No worries — I'm here to help. Let's take it step by step.\n💬 Is there a topic you'd like me to re-explain?" },
            { "frustrated", "😣 I understand this can be frustrating. Let’s go through it slowly.\n💬 Would you like a simpler example?" },
            { "angry", "😣 Cyber topics can be tricky! Let’s breathe and try again.\n💬 What part is bothering you?" },
            { "annoyed", "😣 Don’t worry, we’ll get through this together.\n💬 Would a tip or analogy help you?" },

            // Positive emotions
            { "excited", "😄 I love your enthusiasm! Let’s keep learning.\n💬 What topic are you most excited about?" },
            { "cool", "😄 Glad you think so! Let’s keep exploring!\n💬 Want to learn more about encryption or malware?" },
            { "awesome", "😄 You're awesome too! Let’s keep going!\n💬 What’s something you’d like to master?" }
        };

            // AnalyzeSentiment: returns a response if a keyword matches, else null
            public static string AnalyzeSentiment(string cleanInput)
            {
                if (string.IsNullOrWhiteSpace(cleanInput))
                    return null;

                string lower = cleanInput.ToLower();

                foreach (var kvp in sentimentResponses)
                {
                    if (lower.Contains(kvp.Key))
                        return kvp.Value;
                }
                return null;
            }
        }
    }