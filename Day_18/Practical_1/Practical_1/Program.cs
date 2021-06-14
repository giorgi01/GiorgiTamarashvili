using System;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LinkedItem<int> list = new LinkedItem<int>();
                list[0] = 1;
                list[0] = 2;
                
                list.PrintItems();

                Console.WriteLine(list[2]);
            }
            catch (NotAvailableElementException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: " + ex.Message);
            }
        }
    }
}
