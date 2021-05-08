using System;

namespace Practical_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int num = int.Parse(Console.ReadLine());
            
            // Solution 1 - რიცხვის საკუთარ თავზე გამრავლება
            int squaredNum = num * num;
            Console.WriteLine($"1) The pow of the entered number is {squaredNum}");

            // Solution 2 - C#-ს ფუნქცია
            squaredNum = Convert.ToInt32(Math.Pow(num, 2));
            Console.WriteLine($"2) The pow of the entered number is {squaredNum}");
        }
    }
}
