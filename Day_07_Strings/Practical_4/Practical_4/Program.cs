using System;

namespace Practical_4
{
    class Program
    {
        static int GetWordsCount(string text)
        {
            return (text.Split()).Length;
        }

        static void PrintCount(int count)
        {
            Console.WriteLine(count);
        }

        static void Main(string[] args)
        {
            int count = GetWordsCount("Hello world");
            PrintCount(count);
        }
    }
}
