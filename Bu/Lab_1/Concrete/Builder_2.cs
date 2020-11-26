using Bu.Lab_1.Abstraction;
using Bu.Lab_1.Delegate;

namespace Bu.Lab_1.Concrete
{
    public class Builder_2 : IBuilder
    {

        private Product product = new Product();

        public void BuilderPartA()
        {
            product.Add("Part X");
        }

        public void BuilderPartB()
        {
            product.Add("Part Y");
        }

        public Product GetResult()
        {
            return product;
        }
    }
}
