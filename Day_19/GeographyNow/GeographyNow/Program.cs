using System;
using System.Collections.Generic;

namespace GeographyNow
{
    class Program
    {
        static void Main(string[] args)
        {
            var entity = Menu.GetGeographicEntity();
            Console.WriteLine(entity.ToString());
        }
    }
}
