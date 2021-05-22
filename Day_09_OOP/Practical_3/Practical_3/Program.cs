using System;

namespace Practical_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Time timeSample = new Time();

            Console.Write("Enter hours: ");
            timeSample.Hours = int.Parse(Console.ReadLine());

            Console.Write("Enter minutes: ");
            timeSample.Minutes = int.Parse(Console.ReadLine());
            
            Console.Write("Enter seconds: ");
            timeSample.Seconds = int.Parse(Console.ReadLine());

            timeSample.GetCurrentTime();
            
            timeSample.AddSecond();
            timeSample.GetCurrentTime();
            
            timeSample.SubtractSecond();
            timeSample.GetCurrentTime();
        }
    }
}
