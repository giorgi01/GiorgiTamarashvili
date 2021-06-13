using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    public class DebitIBAN : IBAN
    {
        public DebitIBAN(string number, User owner, double balance) :
                base(number, owner, balance)
        {
            owner.BankAccounts.Add(this);
        }
    }
}
