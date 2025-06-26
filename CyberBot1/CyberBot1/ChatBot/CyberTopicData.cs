using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CyberBot1.ChatBot
{
    public static class CyberTopicData
    {
        // Keywords grouped by topic. Each sub-array contains trigger words for that topic.
        public static string[][] Keywords = new string[][]
        {
                new string[] { "passwords", "password" },
                new string[] { "phishing" },
                new string[] { "malware" },
                new string[] { "safe browsing", "browsing" },
                new string[] { "firewall", "firewalls" },
                new string[] { "encryption" }
        };

        // Detailed responses per topic.
        public static string[][] Responses = new string[][]
        {
                new string[]
                {
                    "🔐 Passwords are your first line of defense. A password is a secret word or phrase that allows access to an account.",
                    "🧠 Strong passwords should include a mix of upper and lower case letters, numbers, and special characters.",
                    "❗ Never use the same password for multiple accounts. This makes it easier for hackers to access more than one service."
                },
                new string[]
                {
                    "🎣 Phishing is a cyber attack where scammers trick you into giving up sensitive information by pretending to be a trusted source.",
                    "📧 These scams often arrive via email or SMS with urgent messages and links to fake websites.",
                    "🚫 Always double-check URLs and email addresses before clicking links or downloading files."
                },
                new string[]
                {
                    "💣 Malware stands for 'malicious software' — programs like viruses, worms, trojans, or ransomware designed to harm your system.",
                    "🛡️ Malware can steal data, take control of your device, or encrypt your files until you pay a ransom.",
                    "🔄 To protect against malware, regularly update software and use reliable antivirus tools."
                },
                new string[]
                {
                    "🌐 Safe browsing means using the internet in a way that reduces your exposure to scams, viruses, and tracking.",
                    "🔒 Always look for HTTPS in the address bar of websites — the 'S' stands for secure.",
                    "👀 Be cautious of pop-ups, suspicious links, and websites asking for unnecessary personal information."
                },
                new string[]
                {
                    "🔥 A firewall is a security system that monitors and controls incoming and outgoing network traffic.",
                    "🚧 It acts as a digital barrier between your device and potential threats from the internet.",
                    "🖥️ Firewalls can be built into your operating system or purchased as dedicated software or hardware."
                },
                new string[]
                {
                    "🔐 Encryption is the process of encoding data so only authorized users can read it.",
                    "🗝️ It protects your personal data during transmission (like emails or online purchases) and when stored.",
                    "📦 Most secure apps today — like WhatsApp and banking platforms — use end-to-end encryption to keep your data safe."
                }
        };

        // Topics in order, matching the index of the arrays above
        public static readonly string[] Topics = new string[]
        {
                "password",
                "phishing",
                "malware",
                "safe browsing",
                "firewall",
                "encryption"
        };

        // Advice for follow-up on a topic
        public static string GetAdviceForTopic(string topic)
        {
            switch (topic)
            {
                case "password":
                    return "🔑 Consider using a trusted password manager to generate and store strong, unique passwords for every account.";
                case "phishing":
                    return "🕵️‍♂️ When in doubt, contact the organization directly instead of replying to a suspicious message or clicking its links.";
                case "malware":
                    return "🧼 Regularly scan your system for threats, avoid downloading unknown files, and never open attachments from unverified sources.";
                case "safe browsing":
                    return "🔎 Use privacy-focused search engines, clear your browser cache regularly, and avoid entering sensitive info on public Wi-Fi.";
                case "firewall":
                    return "🛡️ Make sure your operating system's firewall is enabled and consider installing additional software for enhanced protection.";
                case "encryption":
                    return "🔏 Enable encryption on your devices (like BitLocker or FileVault) and back up your encrypted data securely.";
                default:
                    return "ℹ️ I don't have additional advice for that topic right now, but it's always good to stay informed!";
            }
        }
    }
}
    
    
