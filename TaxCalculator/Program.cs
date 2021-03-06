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
                new MusicProduct("Food", false, 20),
                new MusicProduct("Book",  false, 20),
                new BookProduct("Medical",true, 100),
                new FoodProduct("Medical",  true, 100),
            };

            var receipt = new TaxCalculator(products).GetReceipt();
            Console.Write(receipt);
        }
    }
}
