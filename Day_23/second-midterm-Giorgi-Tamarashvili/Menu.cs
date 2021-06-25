using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace second_midterm_Giorgi_Tamarashvili
{
    static class Menu
    {
        public static Option GetUserOption()
        {
            Console.WriteLine("Choose one of them: 1) Start Test 2) Add test");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                return Option.StartTest;
            }
            else
            {
                return Option.AddTest;
            }
        }
    }
}
