using System;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedItem<int> list = new LinkedItem<int>();
            list[0] = 1;
            list[0] = 2;
            list.PrintItems();
            try
            {
                Console.WriteLine(list[2]);
            }
            catch (NotAvailableElementException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
