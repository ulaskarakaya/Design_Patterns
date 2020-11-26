using Bu.Lab_1.Abstraction;

namespace Bu.Lab_1.Directories
{
    public class Directory
    {
        public void Constructor(IBuilder builder)
        {
            builder.BuilderPartA();
            builder.BuilderPartB();

            builder.BuilderPartB();
            builder.BuilderPartA();
        }
    }
}
