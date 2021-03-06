using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public abstract class Product
    {
        private const decimal ImportedTaxRate = 5;
        private const decimal TaxRate = 10;
        private readonly bool _isImport;
        private readonly string _name;
        public virtual bool IsExampt => false;
  
        
        public decimal Subtotal { get; }

        protected Product(string name, bool isImport, decimal subTotal) 
        {
            _isImport = isImport;
            Subtotal = subTotal;
            _name     = name;
        }

        protected virtual decimal GetTaxRate() 
        {
            var taxRate = IsExampt ? 0 : TaxRate;
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
