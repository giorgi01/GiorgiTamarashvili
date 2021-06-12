using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    public class CreditIBAN : IBAN
    {
        public double Debt { get; set; }
        public CreditIBAN(string number, string ownerFirstName, string ownerLastName, double balance) : 
            base(number, ownerFirstName, ownerLastName, balance)
        {
        }

        public void Borrow(double funds)
        {
            Balance += funds;
            Debt += funds;
        }

        public void Withdraw(double funds)
        {
            Balance -= funds;
        }
    }
}
