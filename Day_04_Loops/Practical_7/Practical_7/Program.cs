using System;

namespace Practical_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            int num = int.Parse(Console.ReadLine());

            string result = "";

            int firstNum = 0;
            int secondNum = 1;

            for (int i = 0; i <= num; i++)
            {
                result += $"{firstNum} ";

                int temp = firstNum;
                firstNum = secondNum;
                secondNum += temp;
            }

            Console.WriteLine(result);
        }
    }
}
