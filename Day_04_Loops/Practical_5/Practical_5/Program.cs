using System;

namespace Practical_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number of rows of Floyd's triangle to be printed: ");
            int num = int.Parse(Console.ReadLine());

            int a, b;

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    a = 1;
                    b = 0;
                }
                else
                {
                    a = 0;
                    b = 1;
                }
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                        Console.Write($"{a} ");
                    else
                        Console.Write($"{b} ");
                }
                Console.Write("\n");
            }
        }
    }
}
