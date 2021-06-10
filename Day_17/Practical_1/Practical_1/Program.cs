using System;
using System.Collections;
using System.Collections.Generic;

namespace Practical_1
{
    class Program
    {
        static void PrintItems(ICollection collection)
        {
            Console.WriteLine();
            if (collection.Count != 0)
            {
                foreach (var item in collection)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("Empty collection");
            }
        }
        static void Main(string[] args)
        {
            Student student1 = new Student("John", "Doe", "001001223");
            Student student2 = new Student("James", "Doe", "001001224");
            Student student3 = new Student("Jacob", "Doe", "001001225");
         
            // List

            List<Student> students = new List<Student>();
            
            students.Add(student1);
            students.Insert(0, student2);
            students.Add(student3);

            PrintItems(students);

            students.RemoveAt(1);

            PrintItems(students);

            students.Add(student1);
            students.Remove(student1);
            students.RemoveRange(0, 2);

            PrintItems(students);

            students.Add(student1);
            students.Add(student1);
            students.Add(student1);
            Console.WriteLine(students.LastIndexOf(student1));
            
            students.Clear();
            Console.WriteLine(students.Capacity);
            students.TrimExcess();
            Console.WriteLine(students.Capacity);

            // Tuple

            var tuple = new Tuple<string, List<Student>>("Students", students);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2.Capacity);

            // Dictionary
            
            Dictionary<string, string> countries = new Dictionary<string, string>();
            countries["GE"] = "Georgia";
            countries["US"] = "United States";
            countries["FR"] = "France";
            countries["TR"] = "Turkey";

            countries.TryGetValue("TR", out string turkey);
            bool added = countries.TryAdd("TR", "Brazil");
            Console.WriteLine(added);

            countries.Remove("TR");

            PrintItems(countries.Keys);
            PrintItems(countries.Values);

            // Stack (LIFO)

            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            
            Console.WriteLine(stack.Peek());
            PrintItems(stack);

            Console.WriteLine(stack.Pop());
            stack.Pop();
            stack.Pop();

            PrintItems(stack);

            stack.Push(0);
            Console.WriteLine(stack.Contains(0));

            // Queue (FIFO)
            Queue<bool> queue = new Queue<bool>();
            queue.Enqueue(true);
            queue.Enqueue(false);
            
            PrintItems(queue);

            Console.WriteLine(queue.Dequeue());
            queue.Dequeue();
            
            PrintItems(queue);

            queue.Enqueue(false);
            queue.Clear();

            PrintItems(queue);
        }
    }
}
