using System;

namespace Practical_2
{
    class Program
    {
        static int GetRangeSum(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num + GetRangeSum(num - 1);
            }
        }

        static void Main(string[] args)
        {
            int firstSum = GetRangeSum(13);
            int secondSum = GetRangeSum(14);

            Console.WriteLine(firstSum);
            Console.WriteLine(secondSum);
        }
    }
}
