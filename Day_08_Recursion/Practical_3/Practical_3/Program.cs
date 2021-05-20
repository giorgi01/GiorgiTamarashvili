using System;

namespace Practical_3
{
    class Program
    {
        static void PrintNumberLength(int num, int counter = 1)
        {
            if (num / 10 == 0)
            {
                Console.WriteLine(counter);
            }
            else
            {
                PrintNumberLength(num / 10, ++counter);
            }
        }

        static void Main(string[] args)
        {
            PrintNumberLength(999);
        }
    }
}
