using System;

namespace Practical_4
{
    class Program
    {
        static int GetWordsCount(string text)
        {
            return (text.Split()).Length;
        }

        static void PrintCount(string text, int count)
        {
            Console.WriteLine($"In phrase \"{text}\" are {count} words");
        }

        static void Main(string[] args)
        {
            string text = "Hello world";
            int count = GetWordsCount(text);
            PrintCount(text, count);
        }
    }
}
