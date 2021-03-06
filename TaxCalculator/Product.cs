using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public class Product
    {
        private const decimal ImportedTaxRate = 5;
        private const decimal TaxRate = 10;
        private readonly bool _isExampt;
        private readonly bool _isImport;
        private readonly string _name;
        public decimal Subtotal { get; }


        public Product(string name, bool isExampt, bool isImport, decimal subTotal) 
        {
            _isExampt = isExampt;
            _isImport = isImport;
            Subtotal = subTotal;
            _name     = name;
        }

        private decimal GetTaxRate() 
        {
            decimal taxRate = _isExampt ? 0 : TaxRate;
            return (_isImport ? taxRate += ImportedTaxRate : taxRate) /  100;
        }
        public decimal GetTax()
        {
          return Utility.RoundOff(Subtotal * GetTaxRate());
        }

        public decimal GetTotal()
        {
            return Subtotal + GetTax();
        }

        public override string ToString()
        {
            return $"{_name}\n\rItem subtotal: {Subtotal}.\n\rItem tax: {GetTax()}.\n\rItem total: {GetTotal()}";
        }

    }
}
