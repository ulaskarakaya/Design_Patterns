using Bu.Lab_2.Abstraction;

namespace Bu.Lab_2.Directories
{
    public class ProductDirectory
    {
        public void GenerateProduct(ProductBuilder productBuilder)
        {
            productBuilder.GetProductData();
            productBuilder.GetModel();
            productBuilder.ApplyDiscount();
        }
    }
}
