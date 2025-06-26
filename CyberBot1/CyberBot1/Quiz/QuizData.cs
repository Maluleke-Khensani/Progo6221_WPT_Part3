using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBot1.Quiz
{
    // This class provides a set of quiz questions related to cybersecurity.
    public static class QuizData
    {
        public static List<QuizQuestion> GetQuestions()
        {
            return new List<QuizQuestion>
    {
      new QuizQuestion {
            QuestionText = "What is the primary goal of cybersecurity?",
            Options = new List<string> { "To make computers run faster", "To protect systems and data from attacks", "To create new software", "To design websites" },
            CorrectAnswerIndex = 1,
            Explanation = "🔐 Cybersecurity protects systems and data from unauthorized access and attacks."
        },
        new QuizQuestion
        {
            QuestionText = "What does 'malware' stand for?",
            Options = new List<string> { "Malicious software", "Malfunctioning software", "Malware is a type of hardware", "Malicious hardware" },
            CorrectAnswerIndex = 0,
            Explanation = "💻 Malware is short for malicious software that harms computers and networks."
        },
        new QuizQuestion
        {
            QuestionText = "True or False: Strong passwords are the only defense against cyber attacks.",
            Options = new List<string> { "True", "False", "", "" },
            CorrectAnswerIndex = 1,
            Explanation = "❌ False. Strong passwords are important, but you also need antivirus, firewalls, and safe browsing habits."
        },
      new QuizQuestion
        {
            QuestionText = "What is phishing?",
            Options = new List<string> { "A type of fish", "A way to catch hackers", "A method to steal personal information", "A cybersecurity tool" },
            CorrectAnswerIndex = 2,
            Explanation = "🎣 Phishing tricks you into giving up personal info. Be careful!"
        },
        new QuizQuestion
        {
            QuestionText = "What should you do if you receive a suspicious email with a link?",
            Options = new List<string> { "Click the link", "Ignore it", "Report it as phishing", "Reply to ask what it is" },
            CorrectAnswerIndex = 2,
            Explanation = "✅ Good job! Reporting phishing helps protect everyone."
        },
        new QuizQuestion
        {
            QuestionText = "True or False: You should use the same password for all your accounts.",
            Options = new List<string> { "True", "False", "", "" },
            CorrectAnswerIndex = 1,
            Explanation = "❌ False. Reusing passwords makes it easier for hackers."
        },
        new QuizQuestion
        {
            QuestionText = "Which of the following is the strongest password?",
            Options = new List<string> { "qwerty", "John123", "Dog@2022", "R8@#m!9Vz" },
            CorrectAnswerIndex = 3,
            Explanation = "🔒 Strong passwords mix symbols, numbers, and are hard to guess."
        },
        new QuizQuestion
        {
            QuestionText = "What does 2FA (Two-Factor Authentication) do?",
            Options = new List<string> { "Confirms your location", "Adds a second layer of security", "Saves your login", "Sends you ads" },
            CorrectAnswerIndex = 1,
            Explanation = "✅ Correct! 2FA protects you with something you know *and* something you have."
        },
        new QuizQuestion
        {
            QuestionText = "True or False: It's safe to use public Wi-Fi without a VPN.",
            Options = new List<string> { "True", "False", "", "" },
            CorrectAnswerIndex = 1,
            Explanation = "⚠️ False. Public Wi-Fi can be hacked. Use a VPN or avoid sensitive activity."
        },
        new QuizQuestion
        {
            QuestionText = "Which is a form of social engineering?",
            Options = new List<string> { "Antivirus", "Phishing", "Encryption", "Two-factor authentication" },
            CorrectAnswerIndex = 1,
            Explanation = "🎭 Phishing tricks people into giving up info — that's social engineering!"
        },
        new QuizQuestion
        {
            QuestionText = "A website’s URL starts with 'http' instead of 'https'. What does this mean?",
            Options = new List<string> { "It’s encrypted", "It’s faster", "It’s not secure", "It’s a trusted site" },
            CorrectAnswerIndex = 2,
            Explanation = "🔐 'HTTPS' is secure. 'HTTP' means info isn't encrypted."
        },
        new QuizQuestion
        {
            QuestionText = "True or False: Antivirus software guarantees 100% protection.",
            Options = new List<string> { "True", "False", "", "" },
            CorrectAnswerIndex = 1,
            Explanation = "🤔 False. Antivirus helps, but you still need to browse safely and update software."
        },
        new QuizQuestion
        {
            QuestionText = "Which file extension is most risky to open from unknown emails?",
            Options = new List<string> { ".pdf", ".jpg", ".exe", ".docx" },
            CorrectAnswerIndex = 2,
            Explanation = "💥 Be careful! '.exe' files can run code and are often used to deliver malware."
        },
        new QuizQuestion
        {
            QuestionText = "🚨 This is a difficult one: What is a zero-day vulnerability?",
            Options = new List<string> { "A bug hackers found before developers", "An outdated app", "A virus without a name", "A password-cracking tool" },
            CorrectAnswerIndex = 0,
            Explanation = "💡 Correct! Zero-day exploits are dangerous because there’s no fix available yet."
        }
    };
        }

    }
}
