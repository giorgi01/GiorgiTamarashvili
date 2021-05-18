using System;

namespace Practical_5
{
    class Program
    {
        static int GetLettersCount(string text)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            text = text.ToUpper();
            int counter = 0;

            foreach (char c in text)
            {
                if (alphabet.Contains(c)) counter += 1;
            }
            return counter;
        }

        static int GetNumbersCount(string text)
        {
            string numbers = "0123456789";
            int counter = 0;

            foreach (char c in text)
            {
                if (numbers.Contains(c)) counter += 1;
            }
            return counter;
        }

        static void PrintTextAnalysis(string text, int lettersCount, int numbersCount)
        {
            int othersCount = text.Length - lettersCount - numbersCount;
            Console.WriteLine($"\"{text}\" -> Letters: {lettersCount}, Numbers: {numbersCount}, Others: {othersCount}");
        }

        static void Main(string[] args)
        {
            string text = "Hello 1 !";
            int lettersCount = GetLettersCount(text);
            int numbersCount = GetNumbersCount(text);
            PrintTextAnalysis(text, lettersCount, numbersCount);
        }
    }
}
