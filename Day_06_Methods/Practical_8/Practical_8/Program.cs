using System;

namespace Practical_8
{
    class Program
    {

        static int GetNumber()
        {
            Console.Write("Enter a positive number: ");
            return int.Parse(Console.ReadLine());
        }

        static void PrintNumber(int num)
        {
            string result = "";
            int pow = 0;

            int tmp = num;
            while (num != 0)
            {
                result = $" {num % 10} * 10^{pow} " + result;
                num /= 10;
                pow++;
                if (num != 0) result = "+" + result;
            }
            result = $"{tmp} =" + result;
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            int num = GetNumber();
            PrintNumber(num);
        }
    }
}
