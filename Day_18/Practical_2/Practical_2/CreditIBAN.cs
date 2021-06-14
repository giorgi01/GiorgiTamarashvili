using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    public class CreditIBAN : IBAN
    {
        public double Debt { get; set; }
        public CreditIBAN(string number, User owner, double balance) : 
            base(number, owner, balance)
        {
            owner.BankAccounts.Add(this);
        }
    }
}
