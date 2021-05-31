using System;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            static double[] GetUserInput()
            {
                double[] userInput = new double[3];
                Console.Write("Please enter a: ");
                userInput[0] = double.Parse(Console.ReadLine());
                Console.Write("Please enter b: ");
                userInput[1] = double.Parse(Console.ReadLine());
                Console.Write("Please enter c: ");
                userInput[2] = double.Parse(Console.ReadLine());

                return userInput;
            }

            static void PrintRoots(double a, double b, double c)
            {
                double bSquared = Math.Pow(b, 2);

                double discriminant = bSquared - (4 * a * c);

                if (discriminant > 0)
                {
                    double x1 = (-b + discriminant) / 2;
                    double x2 = (-b - discriminant) / 2;

                    Console.WriteLine("First root: " + x1);
                    Console.WriteLine("Second root: " + x2);
                }
                else if (discriminant == 0)
                {
                    double root = (-b + discriminant) / 2;

                    Console.WriteLine("Root: " + root);
                }
                else
                {
                    Console.WriteLine("There are no roots");
                }


            }

            double[] userInput = GetUserInput();
            PrintRoots(userInput[0], userInput[1], userInput[2]);
        }
    }
}
