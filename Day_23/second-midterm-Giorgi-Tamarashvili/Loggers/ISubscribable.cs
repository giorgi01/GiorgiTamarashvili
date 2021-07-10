using System;
using System.Collections.Generic;
using System.Text;

namespace second_midterm_Giorgi_Tamarashvili
{
    interface ISubscribable
    {
        public void Subscribe(Publisher publisher);
        public void Unsubscribe(Publisher publisher);
    }
}
