using System;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            static double[] GetUserInput()
            {
                Console.Write("Enter number 1: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter number 2: ");
                double num2 = double.Parse(Console.ReadLine());
                
                return new double[] { num1, num2 };
            }

            double[] userInput = GetUserInput();
            double num = userInput[0];
            double degree = userInput[1];
            
            Status status;
            Console.WriteLine(Math.Pow(num, degree, out status));
            Console.WriteLine(status.ToString());

            userInput = GetUserInput();
            double num1 = userInput[0];
            double num2 = userInput[1];

            double minNum = Math.Min(num1, num2, out status);
            Console.WriteLine("Min num is: " + minNum);
            Console.WriteLine(status.ToString());

            double maxNum = Math.Max(num1, num2, out status);
            Console.WriteLine("Max num is: " + maxNum);
            Console.WriteLine(status.ToString());
        }
    }
}
