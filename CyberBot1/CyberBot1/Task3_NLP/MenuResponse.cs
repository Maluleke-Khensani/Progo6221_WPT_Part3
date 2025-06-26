using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBot1.Task3_NLP
{
    // This class provides responses based on a simple menu system for user interaction.
    public static class MenuResponse
    {
        // This method returns a response based on the user's choice from the menu.
        private static readonly Dictionary<string, string> responses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "how are you", "😊 Running on full power, thanks for asking!" },
            { "what is your purpose", "🤖 I'm here to help you with cybersecurity questions and give you safety tips!" },
            { "what's your name", "🆔 My name is CyberBot, your friendly cybersecurity assistant!" },
            { "tell me a joke", "😂 Why did the computer go to therapy? Because it had too many bytes!" },
            { "do you sleep", "😴 I don't sleep, but I do take breaks to recharge my circuits!" },
            { "what can you do", "🛠️ I can answer your questions about cybersecurity and provide tips to stay safe online." }
        };

        public static string GetResponse(string input)
        {
            foreach (var key in responses.Keys)
            {
                if (input.ToLower().Contains(key))
                    return responses[key];
            }

            return null; // If nothing matches
        }
    }
}

