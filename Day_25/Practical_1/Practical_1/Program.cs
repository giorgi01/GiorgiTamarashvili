using System;
using System.Collections.Generic;
using System.Linq;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = DbManager.GetCustomers();
            var orders = DbManager.GetOrders();
            var ordersPerCustomer = orders.GroupBy(o => o.CustomerId);
            var cWithMoreThanOneOrder = ordersPerCustomer.Where(g => g.Count() > 1);
            var cWithAvgMoreThanTen = ordersPerCustomer.Where(g => g.Average(o => o.Price) > 10).Select(g => new { Key = g.Key, Average = g.Average(o => o.Price) });

            foreach (var g in ordersPerCustomer)
            {
                Console.WriteLine($"Customer id: {g.Key}, orders count: {g.Count()}");
            }

            foreach (var g in ordersPerCustomer)
            {
                Console.WriteLine($"Customer id: {g.Key}, orders sum amount: {g.Sum(o => o.Price)}");
            }

            foreach (var g in ordersPerCustomer)
            {
                Console.WriteLine($"Customer id: {g.Key}, min amount: {g.Min(o => o.Price)}");
            }

            foreach (var g in cWithMoreThanOneOrder)
            {
                Console.WriteLine($"Customer id: {g.Key}, orders count: {g.Count()}");
            }

            foreach (var g in cWithAvgMoreThanTen)
            {
                Console.WriteLine($"Customer id: {g.Key}, average amount: {g.Average}");
            }
        }
    }
}
