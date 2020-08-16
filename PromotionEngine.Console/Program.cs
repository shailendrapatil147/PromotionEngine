using PromotionEngine.Contracts.Models;
using PromotionEngine.Managers;
using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OrderManager orderManager = new OrderManager();
            List<Product> orderedProducts = new List<Product> {
                new Product { Name = "A", TotalUnit = 3 },
                new Product { Name = "B", TotalUnit = 5 },
                new Product { Name = "C", TotalUnit = 1 },
                new Product { Name = "D", TotalUnit = 1 },
            };
            
            double totalBill = orderManager.PlaceOrder( orderedProducts);
            Console.WriteLine($"Total Price :{totalBill}");
            Console.ReadLine();
        }
    }
}
