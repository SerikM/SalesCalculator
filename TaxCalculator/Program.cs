using System;
using System.Collections.Generic;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>() 
            { 
                new Product("Food", true, false, 20),
                new Product("Book", true, false, 20),
                new Product("Medical", false, true, 100),
                new Product("Medical", true, true, 100),
            };

            var receipt = new TaxCalculator(products).GetReceipt();
            Console.Write(receipt);
        }
    }
}
