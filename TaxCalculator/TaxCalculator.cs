using System.Collections.Generic;

namespace TaxCalculator
{
    public class TaxCalculator
    {
        readonly Basket _basket;


        public TaxCalculator(List<Product> items)
        {
            _basket = new Basket(items);
        }

        public decimal CalculateTotalTax() 
        {
            return _basket.GetBasketTax();
        }

        public decimal GetTotalCost()
        {
            return _basket.GetBasketTotal();
        }

        public string GetReceipt()
        {
            return _basket.GetBasketReceipt();
        }
    }
}
