using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CyberBot1.ChatBot;

//Assisted by ChatGPT to import all related cyberBot chat to the WPT
namespace CyberBot1.ChatBot
{
    // This class represents the chat window where users can interact with the CyberBot.
    public partial class ChatWindow : Window
    {
        public ChatWindow()
        {
            InitializeComponent();
        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            var main = new MainWindow();
            main.Show();
            this.Close();
        }


        //The method updates the visibility of the placeholder text based on whether the chat input is empty or not.
        private void ChatInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            PlaceholderText.Visibility = string.IsNullOrWhiteSpace(ChatInput.Text)
                ? Visibility.Visible
                : Visibility.Collapsed;
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string input = ChatInput.Text.Trim();
            if (string.IsNullOrWhiteSpace(input))
                return;

            AppendMessage($"👤 You: {input}");

            string clean = Regex.Replace(input.ToLower(), "[^a-z0-9 ]", "");
            string[] tokens = clean.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // 1. Sentiment check
            string sentimentReply = SentimentAnalyzer.AnalyzeSentiment(clean);
            if (!string.IsNullOrEmpty(sentimentReply))
            {
                AppendMessage($"🤖 CyberBot: {sentimentReply}");
                ChatInput.Text = "";
                return;
            }

            // 2. Follow-up check
            if ((clean.Contains("more") || clean.Contains("explain") || clean.Contains("confused")) && !string.IsNullOrEmpty(CyberQuestions.lastTopic))
            {
                AppendMessage($"🤖 CyberBot: {CyberTopicData.GetAdviceForTopic(CyberQuestions.lastTopic)}");
                ChatInput.Text = "";
                return;
            }

            // 3. Match keywords with topics
            bool found = false;
            for (int i = 0; i < CyberTopicData.Keywords.Length; i++)
            {
                foreach (string keyword in CyberTopicData.Keywords[i])
                {
                    if (tokens.Contains(keyword.ToLower()))
                    {
                        CyberQuestions.lastTopic = CyberTopicData.Topics[i];
                        string response = CyberTopicData.Responses[i][new Random().Next(CyberTopicData.Responses[i].Length)];
                        AppendMessage($"🤖 CyberBot: {response}");
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }

            if (!found)
            {
                AppendMessage("🤖 CyberBot: I’m not sure how to help with that. Try asking about passwords, phishing, malware, firewalls...");
            }

            ChatInput.Text = "";
        }

        private void AppendMessage(string message)
        {
            ChatDisplay.Text += message + "\n\n";
        }
    

    
        // Handles the custom CyberBot chat feature
        public void HandleCyberBotChat(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                ChatInput.Text += "\n⚠️ Please enter a question.\n";
                return;
            }

            string clean = Regex.Replace(input.ToLower(), "[^a-z0-9 ]", "");
            string[] tokens = clean.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // 1. Sentiment detection
            string sentimentReply = SentimentAnalyzer.AnalyzeSentiment(clean);
            if (!string.IsNullOrEmpty(sentimentReply))
            {
                ChatInput.Text += $"\nCyberBot: {sentimentReply}\n";
                return;
            }

            // 2. Short or vague input
            if (tokens.Length == 1 && tokens[0].Length < 4)
            {
                ChatInput.Text += "\nCyberBot: 🤔 Can you ask in more detail?\n";
                return;
            }

            // 3. Keyword detection
            for (int i = 0; i < CyberTopicData.Keywords.Length; i++)
            {
                string[] keywords = CyberTopicData.Keywords[i];
                string[] responses = CyberTopicData.Responses[i];

                foreach (string keyword in keywords)
                {
                    if (tokens.Contains(keyword))
                    {
                        Random rand = new Random();
                        string response = responses[rand.Next(responses.Length)];
                        ChatInput.Text += $"\nCyberBot: {response}\n";
                        return;
                    }
                }
            }


            // 4. Fallback
            ChatInput.Text += "\nCyberBot: ❓ I’m not sure how to help with that.\n";
        }


    }
}
