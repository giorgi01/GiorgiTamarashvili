using System;

namespace Practical_6
{
    class Program
    {
        static char[] BuildArray()
        {

            Console.Write("Enter array size: ");
            int arrSize = int.Parse(Console.ReadLine());

            char[] arr = new char[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                Console.Write($"Enter character for index {i}: ");
                arr[i] = char.Parse(Console.ReadLine());
            }

            return arr;
        }

        static int CountChar(char[] arr, char symbol)
        {
            int counter = 0;

            foreach (char item in arr)
            {
                if (item == symbol) counter += 1;
            }

            return counter;
        }

        static void PrintResult(int counter, char symbol)
        {
            Console.WriteLine($"'{symbol}' shegvxvda {counter}-jer");
        }

        static void Main(string[] args)
        {
            char[] arr = BuildArray();

            int count = CountChar(arr, 'a');
            PrintResult(count, 'a');
        }
    }
}
