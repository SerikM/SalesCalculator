using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxCalculator
{
    public class Basket
    {
        private readonly List<Product> _products;

        public Basket(List<Product> products) 
        {
            _products = products;
        }

        public decimal GetBasketTotal() 
        {
            return _products.Sum(p => p.GetTotal());
        }

        public decimal GetBasketSubTotal()
        {
            return _products.Sum(p => p.Subtotal);
        }

        public decimal GetBasketTax()
        {
            return _products.Sum(p => p.GetTax());
        }

        public string GetBasketReceipt()
        {
            var sb = new StringBuilder();
            sb.Append($"Bill total {GetBasketTotal()}\n\r");
            sb.Append($"Including tax {GetBasketTax()}\n\r");

            _products.ForEach(p => 
            {
                sb.Append(p);
                sb.Append("\n\r");
            });
            return sb.ToString();
        }
    }
}
