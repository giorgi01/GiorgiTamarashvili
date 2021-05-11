using System;

namespace Practical_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            int num = int.Parse(Console.ReadLine());

            string result = $"divisors of {num} are: ";

            for (int i = 1; i <= num; i++)
                if (num % i == 0) result += $"{i}, ";

            Console.WriteLine(result);
        }
    }
}
