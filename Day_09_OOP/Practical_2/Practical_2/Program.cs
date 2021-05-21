using System;

namespace Practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle abc = new Triangle();

            Console.Write("Enter side 1: ");
            abc.FirstSide = double.Parse(Console.ReadLine());

            Console.Write("Enter side 2: ");
            abc.SecondSide = double.Parse(Console.ReadLine());

            Console.Write("Enter side 3: ");
            abc.ThirdSide = double.Parse(Console.ReadLine());

            if (abc.ThirdSide > 0)
            {
                Console.WriteLine("Perimeter of the triangle is: " + abc.GetPerimeter());
                Console.WriteLine("Area of the triangle is: " + abc.GetArea());
            }
        }
    }
}
    