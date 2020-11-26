using Bu.Lab_1.Abstraction;
using Bu.Lab_1.Delegate;

namespace Bu.Lab_1.Concrete
{
    public class Builder_1 : IBuilder
    {
        private Product product = new Product();

        public void BuilderPartA()
        {
            product.Add("Part A");
        }

        public void BuilderPartB()
        {
            product.Add("Bart B");
        }

        public Product GetResult()
        {
            return product;
        }
    }
}
