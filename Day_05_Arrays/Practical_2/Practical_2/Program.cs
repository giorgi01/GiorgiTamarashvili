using System;

namespace Practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int arrSize = int.Parse(Console.ReadLine());

            int[] arr = new int[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                Console.Write($"Enter number for index {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Here is your array in reverse order!");

            // Reverse მეთოდის გარეშე

            for (int i = arrSize - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }

            // Reverse მეთოდით, რომელიც გავიარეთ ლექციაზე

            Console.WriteLine("=======Second method=======");

            Array.Reverse(arr);

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
