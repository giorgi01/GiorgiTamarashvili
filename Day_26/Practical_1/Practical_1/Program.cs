using System;
using System.Collections.Generic;
using System.Linq;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DbManager.PrintOrdersPerCustomer();
            DbManager.PrintOrdersSumAmount();
            DbManager.PrintOrdersMinAmount();
            DbManager.PrintCustomersMoreThanOneOrder();
            DbManager.PrintCsWithAvgAmountMoreThanTen();
        }
    }
}
