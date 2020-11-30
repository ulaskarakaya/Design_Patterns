using ObserverDesign_Pattern.Lab_2.Abstraction;

namespace ObserverDesign_Pattern.Lab_2.Concrete
{
    public class ConcreteProduct : Product
    {
        public ConcreteProduct(string productName, decimal unitPrice) : base(productName, unitPrice)
        {

        }
    }
}
