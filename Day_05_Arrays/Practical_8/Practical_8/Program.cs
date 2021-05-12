using System;

namespace Practical_8
{
    class Program
    {
        static void Main(string[] args)
        {

            // ორგანზომილებიანი მასივით

            Console.WriteLine("Using two dimensional array: ");

            int[,] arr2d = new int[8, 8]
            {
                { 0, 1, 1, 1, 1, 1, 1, 1 },
                { 0, 0, 1, 1, 1, 1, 1, 1 },
                { 0, 0, 0, 1, 1, 1, 1, 1 },
                { 0, 0, 0, 0, 1, 1, 1, 1 },
                { 0, 0, 0, 0, 0, 1, 1, 1 },
                { 0, 0, 0, 0, 0, 0, 1, 1 },
                { 0, 0, 0, 0, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
            };

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(arr2d[i, j]);
                    if (j != 7) Console.Write(", ");
                }
                Console.Write("\n");
            }


            // ამ ციკლით დიაგონალურად შევატრიალე
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int temp = arr2d[i, j];
                    arr2d[i, j] = arr2d[j, i];
                    arr2d[j, i] = temp;
                }
            }

            // ამ ციკლით კი სარკისებურად
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++) // 8/2 გამომდინარეობს j < 4
                {
                    int temp = arr2d[i, j];
                    arr2d[i, j] = arr2d[i, 7 - j]; // 7 - მაქს.ინდექსი
                    arr2d[i, 7 - j] = temp;
                }
            }

            Console.WriteLine("================================Separator line=======================================");

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(arr2d[i, j]);
                    if (j != 7) Console.Write(", ");
                }
                Console.Write("\n");
            }


            // Jagged array-ით

            Console.WriteLine("\nUsing jagged array ");

            int[][] jArray = new int[8][]
            {
                new int[8] { 0, 1, 1, 1, 1, 1, 1, 1 },
                new int[8] { 0, 0, 1, 1, 1, 1, 1, 1 },
                new int[8] { 0, 0, 0, 1, 1, 1, 1, 1 },
                new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
                new int[8] { 0, 0, 0, 0, 0, 1, 1, 1 },
                new int[8] { 0, 0, 0, 0, 0, 0, 1, 1 },
                new int[8] { 0, 0, 0, 0, 0, 0, 0, 1 },
                new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 },
            };


            // ქვემოთ ციკლებში ლოგიკა იგივეა რაც 2დ მასივზე
            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(jArray[i][j]);
                    if (j != 7) Console.Write(", ");
                }
                Console.Write("\n");
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int temp = jArray[i][j];
                    jArray[i][j] = jArray[j][i];
                    jArray[j][i] = temp;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int temp = jArray[i][j];
                    jArray[i][j] = jArray[i][7 - j];
                    jArray[i][7 - j] = temp;
                }
            }

            Console.WriteLine("================================Separator line=======================================");

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(jArray[i][j]);
                    if (j != 7) Console.Write(", ");
                }
                Console.Write("\n");
            }

        }
    }
}
