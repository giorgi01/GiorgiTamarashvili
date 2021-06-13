using System;

namespace Practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User user = new User("John", "Doe", "010000001");
                User user1 = new User("James", "Doe", "010000002");
                DebitIBAN debitIBAN = new DebitIBAN("5020 0219 0124 1111", user, 50);
                DebitIBAN debitIBAN1 = new DebitIBAN("5020 0219 0124 1111", user1, 50);
                CreditIBAN creditIBAN = new CreditIBAN("5021 0219 0124 1111", user, 0);

                Status status;

                ATM.Withdraw(user, debitIBAN, 50, out status);
                Console.WriteLine(status);

                ATM.Borrow(user, creditIBAN, 20);
                ATM.Withdraw(user, creditIBAN, 10, out status);
                Console.WriteLine(status);

                ATM.Withdraw(user1, debitIBAN, 20, out status);
                Console.WriteLine(status);

                ATM.Deposit(user, debitIBAN, 200, out status);
                Console.WriteLine(status);
            }
            catch (Exception ex)
            {
                var errorMessage = "Error occurred: " + ExceptionsManager.GetAllInnerExMessageTogether(ex);
                Console.WriteLine(errorMessage);
            }

        }
    }
}
