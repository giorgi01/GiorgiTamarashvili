using System;

namespace Practical_1
{
    class Program
    {

        static int GetArrayElement(int[] arr, int index)
        {
            return arr[index];
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 5 };
            Console.WriteLine(GetArrayElement(arr, 2));
        }
    }
}
