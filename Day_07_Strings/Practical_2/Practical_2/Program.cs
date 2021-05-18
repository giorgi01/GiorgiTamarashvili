using System;
using System.Text;

namespace Practical_2
{
    class Program
    {

        // ორივე ფუნქცია ასრულებს პირობას, სხვადასხვა სოლუშენით

        static void PrintReverse(string text)
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
            Console.Write("\n");
        }

        // StringBuilder-ის გამოყენებით
        static void PrintReverseSB(string text)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in text)
            {
                sb.Insert(0, c);
            }
            Console.WriteLine(sb);
        }

        static void Main(string[] args)
        {
            PrintReverse("Hello");
            PrintReverseSB("Hello");
        }
    }
}
