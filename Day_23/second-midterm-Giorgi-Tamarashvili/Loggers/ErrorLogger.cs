using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace second_midterm_Giorgi_Tamarashvili
{
    public class ErrorLogger : Logger, ISubscribable
    {

        public ErrorLogger(string path)
        {
            Path = path;
        }

        public void Subscribe(Publisher publisher)
        {
            publisher.ErrorOccured += Log;
        }

        public void Unsubscribe(Publisher publisher)
        {
            publisher.ErrorOccured -= Log;
        }
    }
}
