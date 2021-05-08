using System;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number:");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine($"Entered number {num} is even");
            else
                Console.WriteLine($"Entered number {num} is odd");
        }
    }
}
