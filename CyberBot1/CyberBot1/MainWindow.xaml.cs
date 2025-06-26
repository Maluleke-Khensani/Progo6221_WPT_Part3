using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CyberBot1.Task3_NLP;
using CyberBot1.Quiz;
using System.Text.RegularExpressions;
using CyberBot1.ChatBot;
using CyberBot1.Logging;
using CyberBot1.TaskManager;
using System.Xml.Linq;

namespace CyberBot1
{
    //This class shows all the features of the CyberBot application in the main window.
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

         private void OpenTaskManager_Click(object sender, RoutedEventArgs e)
        {
            var taskWindow = new TaskManagerWindow();
            taskWindow.Show();

        }

        private void OpenQuiz_Click(object sender, RoutedEventArgs e)
        {
            var quizWindow = new Quiz.QuizWindow();
            quizWindow.Show();
        }

        private void WhoIsCyberBot_Click(object sender, RoutedEventArgs e)
        {
            string input = "What is your purpose";
            NlpInputBox.Text = input;

        }


        private void RandomTip_Click(object sender, RoutedEventArgs e)
        {
            NlpResponseText.Text = CyberTip.GetRandomTip();
            ActivityLog.Add("Displayed random cybersecurity tip");
        }

        private void StartChatWithCyberBot_Click(object sender, RoutedEventArgs e)
{
            //creted a new instance of ChatWindow and show it
            ChatWindow chatWindow = new ChatWindow();
            ActivityLog.Add("Opened ChatWindow from main menu");
            chatWindow.Show();
}
        private void ShowHistory_Click(object sender, RoutedEventArgs e)
        {
            // Get the last 10 log entries
            var recent = ActivityLog.GetRecent(10);
            ActivityLog.Add("Viewed activity log");

            if (recent.Count == 0)
            {
                ChatHistoryTextBlock.Text = "📜 No recent activity.";
            }
            else
            {
                var sb = new StringBuilder();
                sb.AppendLine("📜 Recent Activity:");
                int idx = 1;
                foreach (var entry in recent)
                {
                    sb.AppendLine($"{idx++}. {entry}");
                }

                ChatHistoryTextBlock.Text = sb.ToString();
            }
        }

        private void SubmitNlp_Click(object sender, RoutedEventArgs e)
        {
            string input = NlpInputBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                NlpResponseText.Text = "⚠️ Please type something first.";
                return;
            }

            // Check menu-style responses first
            string menuReply = MenuResponse.GetResponse(input);
            if (!string.IsNullOrEmpty(menuReply))
            {
                NlpResponseText.Text = menuReply;
                ChatHistoryTextBlock.Text += $"🧑 You: {input}\n🤖 CyberBot: {menuReply}\n\n";
                NlpInputBox.Text = "";
                return;
            }

            // Then do the main NLP check
            
       

        string result = NlpProcessor.AnalyzeInput(input);

            switch (result)
            {
                // Show a random cybersecurity tip
                case "ShowTips":
                    ActivityLog.Add("Displayed random tip");
                    NlpResponseText.Text = $"💡 Here is a tip: {CyberTip.GetRandomTip()}";
                    break;

                case "WhoIsCyberBot":
                    ActivityLog.Add("Asked who CyberBot is");
                    // Respond with name/purpose
                    NlpResponseText.Text = "🤖 I am CyberBot, your friendly cybersecurity assistant. " +
                                           "I can help you manage tasks, take quizzes, give tips, and chat about security.";
                    break;

                case "OpenChat":
                    ActivityLog.Add("Opened ChatWindow");
                    NlpResponseText.Text = "💬 Opening chat window...";
                    new ChatWindow().Show();
                    this.Close();
                    break;


                case "AddTask":
                    ActivityLog.Add("Opened Task Manager");
                    NlpResponseText.Text = "📝 Opening Task Manager...";
                    new TaskManagerWindow().Show();
                    this.Close(); // or Hide() if you prefer
                    break;

                case "SetReminder":
                    var rem = NlpProcessor.ExtractReminderDetails(input);
                    ActivityLog.Add($"Reminder noted: {rem}");
                    NlpResponseText.Text = $"📌 Reminder noted: {rem}";
                    break;

                case "StartQuiz":
                    ActivityLog.Add("Started quiz via NLP");
                    NlpResponseText.Text = "🧠 Launching Quiz...";
                    new QuizWindow().Show();
                    this.Close(); // or Hide()
                    break;

                case "ShowLog":
                    ActivityLog.Add("Viewed activity log");
                     NlpResponseText.Text = "📜 No recent activity.";
                     break;

                default:
                    ActivityLog.Add($"Unrecognized NLP command: '{input}'");
                    NlpResponseText.Text = "🤖 I didn’t understand. Try: 'add a task', 'start quiz', or 'show activity log'.";
                    break;
            }

            NlpInputBox.Text = "";
        }



    }
}
