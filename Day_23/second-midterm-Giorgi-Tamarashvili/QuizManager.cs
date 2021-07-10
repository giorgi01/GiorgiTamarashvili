using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace second_midterm_Giorgi_Tamarashvili
{
    static class QuizManager
    {

        public static void StartTest()
        {
            Publisher pub = new Publisher();
            ChoiceLogger logger = new ChoiceLogger("logs.txt");
            logger.Subscribe(pub);

            int counter = 0;
            List<Question> questions = GetQuestions();
            foreach (Question question in questions)
            {
                Console.WriteLine(question.Text);
                Answer correctAns = null;
                foreach (Answer answer in question.Answers)
                {
                    Console.WriteLine(answer.Text);
                    if (AnswerIsCorrect(answer)) correctAns = answer;
                }
                int answerIndex = GetUserAnswer();
                if (AnswerIsCorrect(question.Answers[answerIndex - 1]))
                {
                    counter += 1;
                }
                var choice_text = $"Question: {question.Text} User choice: {question.Answers[answerIndex - 1].Text} | Correct answer: {correctAns.Text}";
                pub.OnChoiceMade(choice_text);
                Console.WriteLine("Correct answer was: " + correctAns.Text);
            }
            Console.WriteLine($"Your result is : {counter}/{questions.Count}");
        }

        public static void AddTest()
        {
            Question question = GetQuestion();
            List<Answer> answers = GetAnswers();

            StringBuilder questionText = new StringBuilder();

            using (StreamWriter sw = new StreamWriter("Tests.txt", true, Encoding.Default))
            {
                questionText.Append(question.Text);
                int index = 1;
                foreach (Answer answer in answers)
                {
                    questionText.Append($" | {index}) ");
                    questionText.Append(answer.Text);
                    index += 1;
                }
                sw.WriteLine(questionText);
            }
        }

        private static List<Question> GetQuestions()
        {
            List<Question> questions = new List<Question>();
            StreamReader sr = new StreamReader("Tests.txt");

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] splittedLine = line.Split('|');

                List<Answer> answers = new List<Answer>(4);
                for (int i = 1; i < splittedLine.Length; i++)
                {
                    if (splittedLine[i].Contains('*'))
                    {
                        string correctAnswerText = splittedLine[i];
                        Answer correctAnswer = new Answer(correctAnswerText.Remove(correctAnswerText.IndexOf('*')), true);
                        answers.Add(correctAnswer);
                    }
                    else
                    {
                        answers.Add(new Answer(splittedLine[i], false));
                    }
                }
                questions.Add(new Question(splittedLine[0], answers));
            }

            return questions;
        }

        private static int GetUserAnswer()
        {
            int answer = int.Parse(Console.ReadLine());
            return answer;
        }

        private static bool AnswerIsCorrect(Answer answer)
        {
            return answer.IsCorrect;
        }

        private static Question GetQuestion()
        {
            Console.WriteLine("Enter the question: ");
            string questionText = Console.ReadLine();
            return new Question(questionText);
        }

        private static List<Answer> GetAnswers()
        {
            List<Answer> answers = new List<Answer>(4);
            Console.WriteLine("Enter 4 answers separating Enter button, if the answer is correct select it with '*' symbol at the end");
            for (int i = 0; i < 4; i++)
            {
                string answerText = Console.ReadLine();
                bool correctAns = answerText.Contains('*');
                if (correctAns)
                {
                    foreach (var answer in answers)
                    {
                        if (answer.IsCorrect) throw new SecondCorrectAnswerException("ori swori pasuxis arseboba miugebelia");
                    }
                }
                answers.Add(new Answer(answerText, correctAns));
            }
            return answers;
        }
    }
}
