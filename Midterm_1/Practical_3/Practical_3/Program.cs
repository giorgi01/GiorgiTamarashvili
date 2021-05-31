using System;
using System.IO;

namespace Practical_3
{
    class Program
    {
        static void Main(string[] args)
        {
            static void PrintFiles(string path)
            {
                if (!Directory.Exists(path))
                {
                    Console.WriteLine("Does not exist!");
                    return;
                }

                string[] directories = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);
                
                if (directories.Length == 0)
                {
                    foreach (var file in files)
                    {
                        Console.WriteLine(file);
                    }
                }
                else
                {
                    foreach (var file in files)
                    {
                        Console.WriteLine(file);
                    }

                    foreach (var item in directories)
                    {
                        PrintFiles(item);
                    }
                }
            }

            Console.WriteLine("To turn off program type \"exit\" otherwise enter the directory path");
            string input = Console.ReadLine();
            while (input != "exit")
            {
                PrintFiles(input);
                input = Console.ReadLine();
            }
        }
    }
}
