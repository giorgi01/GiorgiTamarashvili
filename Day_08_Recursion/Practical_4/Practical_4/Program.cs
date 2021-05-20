using System;

namespace Practical_4
{
    class Program
    {
        static int RecursivePow(int num, int pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                return num * RecursivePow(num, pow - 1);
            }

        }

        static void Main(string[] args)
        {
            int threeCubed = RecursivePow(3, 3);
            Console.WriteLine(threeCubed);
        }
    }
}
