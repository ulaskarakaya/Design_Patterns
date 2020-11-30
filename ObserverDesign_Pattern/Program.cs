using ObserverDesign_Pattern.Lab_1.Concrete;
using ObserverDesign_Pattern.Lab_1.EventManager;
using ObserverDesign_Pattern.Lab_2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesign_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1
            var customerObserver = new CustomerObserver();
            ProductManager productManager = new ProductManager();

            productManager.Attached(customerObserver);
            productManager.Attached(new EmployeeObserver());
            productManager.UpdatePrice();

            Console.ReadKey();
            #endregion

            #region
            ConcreteProduct product = new ConcreteProduct("Boxing Gloves", 12.25M);




            product.FollowList.Add(new ConcreteMember { Email = "ulas@gmail.com" });


            product.Price = 8.99M;

            Console.ReadKey();
            #endregion.
        }
    }
}
