using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBot1.Quiz
{
    //This class represents a quiz question with its text, options, correct answer index, and an explanation.
    
    public class QuizQuestion
    {

        //declaration of properties for the QuizQuestion class
        public string QuestionText { get; set; }   // The text of the question
        public List<string> Options { get; set; } = new List<string>();
        public int CorrectAnswerIndex { get; set; }
        public string Explanation { get; set; }
    }
}
