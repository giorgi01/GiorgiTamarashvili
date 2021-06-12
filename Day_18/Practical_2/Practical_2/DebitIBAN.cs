using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    public class DebitIBAN : IBAN
    {
        public DebitIBAN(string number, string ownerFirstName, string ownerLastName, double balance) :
                base(number, ownerFirstName, ownerLastName, balance)
        {
        }

        public void Deposit(double funds)
        {
            Balance += funds;
        }

        public void Withdraw(double funds)
        {
            Balance -= funds;
        }
    }
}
