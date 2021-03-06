using System;

namespace TaxCalculator
{
   public static class Utility
    {
        public static decimal RoundOff(decimal val)
        {
            return Math.Ceiling(val * 20) / 20;
        }
    }
}
