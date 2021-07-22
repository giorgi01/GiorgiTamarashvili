namespace Midterm_2
{
    public class Answer
    {
        public string Text { get; set; }
        public bool Correct { get; set; }

        public Answer(string text, bool correct)
        {
            Text = text;
            Correct = correct;
        }
    }
}