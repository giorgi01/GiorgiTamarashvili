using System;

namespace Practical_1
{
    class Program
    {
        static void PrintRange(int num)
        {
            if (num == 1)
            {
                Console.Write(1 + " ");
            }
            else
            {
                PrintRange(num - 1);
                Console.Write(num + " ");
            }
        }

        static void Main(string[] args)
        {
            PrintRange(12);
            Console.Write("\n");
            PrintRange(15);
        }
    }
}
