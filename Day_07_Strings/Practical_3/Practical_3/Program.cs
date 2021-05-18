using System;
using System.Text;

namespace Practical_3
{
    class Program
    {
        static void PrintText(string text)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in text)
            {
                sb.Append(c);
                sb.Append(" ");
            }
            Console.WriteLine(sb);
        }

        static void Main(string[] args)
        {
            PrintText("hello");
        }
    }
}
