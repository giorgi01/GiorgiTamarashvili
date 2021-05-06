using System;

namespace Practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter year");
            string inputYear = Console.ReadLine();
            int year = Convert.ToInt32(inputYear);

            // !(მარტივი წელიწადი) === ნაკიანი წელიწადი
            bool commonYear = year % 4 != 0 || (year % 100 == 0 && year % 400 != 0);
            Console.WriteLine(!commonYear);
        }
    }
}
