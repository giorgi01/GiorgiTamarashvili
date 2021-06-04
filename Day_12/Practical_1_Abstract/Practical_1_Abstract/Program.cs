using System;

namespace Practical_1_Abstract
{
    class Program
    {
        static Point[] GetPoints(int n)
        {
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + 1 + " point");

                Console.Write("Enter x coordinate: ");
                double x = double.Parse(Console.ReadLine());

                Console.Write("Enter y coordinate: ");
                double y = double.Parse(Console.ReadLine());

                points[i] = new Point(x, y);
            }
            return points;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter rectangle points");
            Point[] rectPoints = GetPoints(4);
            Rectangle rectangle = new Rectangle(rectPoints[0], rectPoints[1], rectPoints[2], rectPoints[3]);

            Console.WriteLine("Enter triangle points");
            Point[] trianglePoints = GetPoints(3);
            Triangle triangle = new Triangle(trianglePoints[0], trianglePoints[1], trianglePoints[2]);

            Console.WriteLine("Enter circle points");
            Point[] circlePoints = GetPoints(2);
            Circle circle = new Circle(circlePoints[0], circlePoints[1]);

            Shape[] shapes = new Shape[] { rectangle, triangle, circle };
            foreach (var shape in shapes)
            {
                string shapeName = shape.ToString();
                shapeName = shapeName.Substring(shapeName.IndexOf('.') + 1);
                Console.WriteLine($"{shapeName} Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
            }
        }
    }
}
