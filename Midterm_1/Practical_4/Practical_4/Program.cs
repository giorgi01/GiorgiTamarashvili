using System;

namespace Practical_4
{
    class Program
    {
        static void Main(string[] args)
        {
            static int[] GetNumbers()
            {
                Console.WriteLine("Please enter first number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter second number: ");
                int num2 = int.Parse(Console.ReadLine());

                return new int[]{ num1, num2 };
            }

            static string GetOperationType()
            {
                Console.WriteLine("Please enter operation sign: ");
                string operation = Console.ReadLine();
                return operation;
            }

            static void Calculate(int a, int b, string op)
            {
                switch (op)
                {
                    case "+":
                        Console.WriteLine(a + b);
                        break;
                    case "-":
                        Console.WriteLine(a - b);
                        break;
                    case "*":
                        Console.WriteLine(a * b);
                        break;
                    case "pow":
                        Console.WriteLine(Math.Pow(a, b));
                        break;
                    case "sqrt":
                        Console.WriteLine(Math.Sqrt(a));
                        Console.WriteLine(Math.Sqrt(a));
                        break;
                    default:
                        break;
                }
            }

            int[] numbers = GetNumbers();
            string op = GetOperationType();
            Calculate(numbers[0], numbers[1], op);
        }
    }
}
