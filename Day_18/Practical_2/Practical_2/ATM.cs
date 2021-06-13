using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    public static class ATM
    {
        private static readonly double _commissionFee = 2.2;

        public static void Withdraw(User user, IBAN bankAccount, double funds, out Status status)
        {
            try
            {
                if (IsValidUser(bankAccount, user))
                {
                    if (IsValidWithdrawal(bankAccount, funds))
                    {
                        bankAccount.Balance -= funds;
                        status = Status.Success;
                    }
                    else
                    {
                        status = Status.Failed;
                        throw new NotValidFundsException("Not valid funds");
                    }
                }
                else
                {
                    throw new IncorrectUserExepction("Not valid user");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Some exception", ex); // უბრალოდ innerException-ს დასანახად გავაკეთე, უტრირებული მაგალითია
            }
        }

        public static void Deposit(User user, IBAN bankAccount, double funds, out Status status)
        {
            if (IsValidUser(bankAccount, user))
            {
                if(bankAccount is CreditIBAN)
                {
                    CreditIBAN creditAcc = (CreditIBAN)bankAccount;
                    creditAcc.Balance += funds;
                    creditAcc.Balance -= creditAcc.Debt;
                    creditAcc.Debt -= funds;
                }
                else
                {
                    bankAccount.Balance += funds;
                }
                status = Status.Success;
            }
            else
            {
                status = Status.Failed;
                throw new IncorrectUserExepction("Incorrect User");
            }
        }

        public static void Borrow(User user, CreditIBAN bankAccount, double funds)
        {
            if(IsValidUser(bankAccount, user))
            {
                bankAccount.Balance += funds;
                bankAccount.Debt += funds;
            }
            else
            {
                throw new IncorrectUserExepction("Incorrect User");
            }
        }

        private static bool IsValidWithdrawal(IBAN bankAccount, double funds)
        {
            if (funds + funds * (_commissionFee / 100) > bankAccount.Balance)
            {
                return false;
            }
            return true;
        }

        private static bool IsValidUser(IBAN bankAccount, User user)
        {
            return bankAccount.Owner == user;
        }
    }
}
