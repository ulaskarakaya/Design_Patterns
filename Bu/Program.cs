using Bu.Lab_1.Abstraction;
using Bu.Lab_1.Concrete;
using Bu.Lab_1.Delegate;
using Bu.Lab_1.Directories;
using Bu.Lab_2.Abstraction;
using Bu.Lab_2.Concrete;
using Bu.Lab_2.Directories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesing_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1
            Directory directory = new Directory();
            IBuilder b_1 = new Builder_1();
            IBuilder b_2 = new Builder_2();

            directory.Constructor(b_1);
            Product p_1 = b_1.GetResult();
            p_1.Display();

            directory.Constructor(b_2);
            Product p_2 = b_2.GetResult();
            p_2.Display();

            Console.ReadKey();
            #endregion

            #region Lab_2
            ProductDirectory directory_2 = new ProductDirectory();
            ProductBuilder builder = new A_ProductBuilder();

            directory_2.GenerateProduct(builder);

            var model = builder.GetModel();

            Console.WriteLine(model.Id);
            Console.WriteLine(model.ProductName);
            Console.WriteLine(model.UnitPrice);
            Console.WriteLine(model.DiscountPrice);
            Console.WriteLine(model.DiscountedApplied);

            Console.ReadKey();
            #endregion


        }
    }
}
