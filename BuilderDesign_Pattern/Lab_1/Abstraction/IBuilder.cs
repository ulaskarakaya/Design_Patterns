using Bu.Lab_1.Delegate;

namespace Bu.Lab_1.Abstraction
{
    public interface IBuilder
    {
        void BuilderPartA();
        void BuilderPartB();
        Product GetResult();
    }
}
