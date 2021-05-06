using System;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50, b = 100;

            // აქ გამოვიყენე სტრინგის ინტერპოლაცია, კონკატენაციის გამოყენებაც შეიძლებოდა
            Console.WriteLine($"Variable values before swap: a -> {a}, b -> {b}");

            // ვარიანტი - ა, მესამე ცვლადის გამოყენებით
            
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("\nMethod 1: Using third variable");
            Console.WriteLine($"Variable values after swap: a -> {a}, b -> {b}");

            // ვარიანტი - ბ, მესამე ცვლადის გამოყენების გარეშე

            a = 50;
            b = 100;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("\nMethod 2: Mathematical solution");
            Console.WriteLine($"Variable values after swap: a -> {a}, b -> {b}");

            // C# 7 ვერსიიდან შეგვიძლია ასეც გავაკეთოთ 
            a = 50;
            b = 100;

            (a, b) = (b, a);

            Console.WriteLine("\nMethod 3: C# 7+ Syntactic sugar");
            Console.WriteLine($"Variable values after swap: a -> {a}, b -> {b}");
        }
    }
}
