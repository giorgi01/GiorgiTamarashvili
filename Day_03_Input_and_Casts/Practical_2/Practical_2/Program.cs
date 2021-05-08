using System;

namespace Practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter second number:");
            int b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter third number:");
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine("This should be a triangle !");
            else
                Console.WriteLine("This cannot be a triangle !");
        }
    }
}
