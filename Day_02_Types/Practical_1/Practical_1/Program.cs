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
            
            Console.WriteLine($"Variable values after swap: a -> {a}, b -> {b}");

            // ვარიანტი - ბ, მესამე ცვლადის გამოყენების გარეშე

            a = 50;
            b = 100;

            (a, b) = (b, a);

            Console.WriteLine($"Variable values after swap: a -> {a}, b -> {b}");

        }
    }
}
