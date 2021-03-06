
namespace TaxCalculator
{
    public class MusicProduct: Product
    {
        public override bool IsExampt => true;
        public MusicProduct(string name, bool isImport, decimal subTotal):base( name, isImport, subTotal)
        {

        }
    }
}
