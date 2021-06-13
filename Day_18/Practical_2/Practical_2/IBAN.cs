using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    abstract public class IBAN
    {
        public string Number { get; set; }
        public User Owner { get; set; }
        public double Balance { get; set; }
        public IBAN(string number, User owner, double balance)
        {
            Number = number;
            Owner = owner;
            Balance = balance;
        }
    }
}
