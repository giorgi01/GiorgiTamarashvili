using System;

namespace Practical_9
{
    class Program
    {
        static int GetArrayProduct(params int[] numbers)
        {
            int product = 1;

            foreach (int item in numbers)
            {
                product *= item;
            }

            return product;
        }

        static void Main(string[] args)
        {
            int product = GetArrayProduct(1, 3, 4, 15, 13, 23, 98);
            Console.WriteLine($"The product of array elements is: {product}");
        }
    }
}
