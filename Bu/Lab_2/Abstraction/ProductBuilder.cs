using Bu.Lab_2.Delegate;

namespace Bu.Lab_2.Abstraction
{
    public abstract class ProductBuilder
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();
        public abstract ProductModel GetModel();
    }
}
