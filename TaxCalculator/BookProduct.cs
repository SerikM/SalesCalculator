
namespace TaxCalculator
{
    public class BookProduct : Product
    {
        public override bool IsExampt => true;
        public BookProduct(string name, bool isImport, decimal subTotal) : base(name, isImport, subTotal)
        {

        }
    }
}
