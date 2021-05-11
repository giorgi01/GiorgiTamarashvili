using System;

namespace Practical_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
                Console.WriteLine($"{i} cubed is {i*i*i}");
        }
    }
}
