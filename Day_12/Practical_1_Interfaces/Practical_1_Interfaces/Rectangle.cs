using System;

namespace Practical_1_Interfaces
{
    public class Rectangle : IShapeable
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Point D { get; set; }

        public Rectangle(Point a, Point b, Point c, Point d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public double Area()
        {
            return SideLength(A, B) * SideLength(B, C);
        }

        public double Perimeter()
        {
            return SideLength(A, B) + SideLength(B, C) + SideLength(C, D) + SideLength(D, A);
        }

        // ეს მეთოდი მაქვს სამივეგან ერთნაირად იმლემენტირებული, 
        // ვიცი dry კოდის პრინციპს რომ ვარღვევ მარა მხოლოდ ინტერფეისებით სხვანაირად არ გამოდიოდა
        private double SideLength(Point a, Point b) 
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }
    }
}