using System;

namespace Practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            
            int sum = 0;

            for (int i = 1; i <= num; i++)
                sum += i;

            Console.WriteLine($"Sum from 1 to {num} is {sum}");
        }
    }
}
