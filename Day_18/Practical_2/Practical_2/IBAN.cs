using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    abstract public class IBAN
    {
        public string Number { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public double Balance { get; set; }
        public IBAN(string number, string firstName, string lastName, double balance)
        {
            Number = number;
            OwnerFirstName = firstName;
            OwnerLastName = lastName;
            Balance = balance;
        }
    }
}
