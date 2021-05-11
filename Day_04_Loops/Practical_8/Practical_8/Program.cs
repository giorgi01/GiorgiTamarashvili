using System;

namespace Practical_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            string binaryForm = "";

            int tmp = num;
            while (tmp != 0)
            {
                binaryForm = tmp % 2 + binaryForm; // ნაშთი
                tmp /= 2;
            }

            Console.WriteLine($"decimal {num} in binary is {binaryForm}");
        }
    }
}
