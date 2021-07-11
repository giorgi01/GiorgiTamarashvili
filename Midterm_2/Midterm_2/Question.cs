using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm_2
{
    public class Question
    {
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }
        public Question(string text)
        {
            Text = text;
        }
        public Question(string text, List<Answer> answers)
        {
            Text = text;
            Answers = answers;
        }

    }
}
