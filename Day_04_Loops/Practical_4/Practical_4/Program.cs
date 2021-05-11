using System;

namespace Practical_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= num; i++)
                if (i % 2 != 0) sum += i;

            Console.WriteLine($"sum of odd number from 1 to {num} is {sum}");
        }
    }
}
