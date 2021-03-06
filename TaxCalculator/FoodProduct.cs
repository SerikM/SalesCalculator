
namespace TaxCalculator
{
    public class FoodProduct : Product
    {
        public override bool IsExampt => true;
        public FoodProduct(string name, bool isImport, decimal subTotal) : base(name, isImport, subTotal)
        {

        }
    }
}
