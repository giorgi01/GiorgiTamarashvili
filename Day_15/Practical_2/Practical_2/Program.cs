using System;

namespace Practical_2
{
    class Program
    {
        public static Triangle GetTriangle()
        {
            Console.Write("Enter A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter C: ");
            double c = double.Parse(Console.ReadLine());

            return new Triangle(a, b, c);
        }
        static void Main(string[] args)
        {
            Triangle triangle = GetTriangle();
            Triangle someTriangle = GetTriangle();

            Console.WriteLine(triangle.Area());
            Console.WriteLine(someTriangle.Area());
            
            Triangle anotherTriangle = triangle + someTriangle;
            Console.WriteLine(anotherTriangle.Area());
        }
    }
}
