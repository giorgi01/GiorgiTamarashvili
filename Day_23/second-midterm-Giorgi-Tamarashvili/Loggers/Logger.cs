using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace second_midterm_Giorgi_Tamarashvili
{
    public class Logger
    {
        public string Path { get; set; }
        protected virtual void Log(string message)
        {
            using (StreamWriter sw = new StreamWriter(Path, true))
            {
                sw.WriteLine(message);
            }
        }
    }
}
