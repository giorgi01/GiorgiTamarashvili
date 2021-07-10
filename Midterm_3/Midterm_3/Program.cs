using System;
using System.Collections.Generic;
using System.Linq;

namespace Midterm_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> list = new List<int>();
                MyList<int> integers = new MyList<int>();
                integers.Add(2);
                integers.Add(3);
                integers.Add(4);
                integers.Add(4);
                integers.Remove(4);
                integers.AddRange(1, 2, 3);
                integers.RemoveAt(0);
                integers.RemoveRange(0, 2);
                Console.WriteLine(integers.Indexer(4));
                Console.WriteLine(integers.Indexer(20));
                foreach (var item in integers)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(integers.Count());
                Console.WriteLine(integers.Contains(8));
                Console.WriteLine(integers.Single(x => x > 2));
                Console.WriteLine(integers.SingleOrDefault(x => x > 10));

                var filteredMyList = integers.Where(x => x > 3);
                foreach (var item in filteredMyList)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine(filteredMyList.Find(x => x < 0));
            }
            catch (SingleDidNotFoundAnElementException ex)
            {
                Console.WriteLine("Custom exception: " + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Occured exception: " + ex.Message);
            }
        }
    }
}
