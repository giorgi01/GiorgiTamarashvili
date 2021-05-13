using System;

namespace Practical_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            int num = int.Parse(Console.ReadLine());

            string result = "0 ";

            int firstNum = 0;
            int secondNum = 1;

            for (int i = 1; i <= num; i++)
            {
                int temp = firstNum;
                firstNum = secondNum;
                secondNum += temp;

                result += $"{firstNum} ";
            }

            Console.WriteLine(result);
        }
    }
}
