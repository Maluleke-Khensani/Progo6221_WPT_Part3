using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberBot1.Logging;
using System.Xml.Linq;

namespace CyberBot1.Task3_NLP
{
     public static class CyberTip
        {
            private static readonly List<string> tips = new List<string>
        {
            "Use a password manager to generate and store strong passwords.🔑",
            "Enable Two-Factor Authentication (2FA) wherever possible.🔐",
            "Be cautious of unsolicited emails and messages asking for personal information.",
            "Regularly update your software and devices to patch security vulnerabilities.🔄",
            "Educate yourself about common cyber threats and scams."
           
        };

            public static string GetRandomTip()
            {
                var rand = new Random();
                return $"💡 Tip: {tips[rand.Next(tips.Count)]}";

            
        }
        }
    }
