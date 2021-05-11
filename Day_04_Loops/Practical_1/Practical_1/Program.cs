using System;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for(int i = 0; i < 11; i++) // 10-ის ჩათვლით
                sum += i;
            
            Console.WriteLine(sum);
        }
    }
}
