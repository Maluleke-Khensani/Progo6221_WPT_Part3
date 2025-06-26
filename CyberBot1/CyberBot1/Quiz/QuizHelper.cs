using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBot1.Quiz
{
    public static class QuizHelper
    {

        //This class provides positive and other responses for quiz interactions.
        public static string GetPositiveResponse()
        {
            var list = new List<string>
            {
                "Great job!",
                "Well done!",
                "You're getting it!",
                "Nice answer!",
                "Correct!"
            };
            return list[new Random().Next(list.Count)];
        }

        public static string GetNegativeResponse()
        {
            var list = new List<string>
            {
                "Oops! That's not right.",
                "Not quite. Try to remember this!",
                "That's incorrect.",
                "Hmm, that wasn't the right choice.",
                "Keep trying! You'll get it."
            };
            return list[new Random().Next(list.Count)];
        }
    }
}