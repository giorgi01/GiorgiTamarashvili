using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace second_midterm_Giorgi_Tamarashvili
{
    public class ChoiceLogger : Logger, ISubscribable
    {
        public ChoiceLogger(string path)
        {
            Path = path;
        }

        public void Subscribe(Publisher publisher)
        {
            publisher.ChoiceMade += Log;
        }

        public void Unsubscribe(Publisher publisher)
        {
            publisher.ChoiceMade -= Log;
        }
    }
}
