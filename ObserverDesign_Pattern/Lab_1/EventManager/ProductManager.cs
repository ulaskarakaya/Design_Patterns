using ObserverDesign_Pattern.Lab_1.Abstraction;
using System;
using System.Collections.Generic;

namespace ObserverDesign_Pattern.Lab_1.EventManager
{
    public class ProductManager
    {
        List<BaseObserver> _observers = new List<BaseObserver>();

        public void UpdatePrice()
        {
            Console.WriteLine("Product price changed..!");
            Notification();
        }

        public void Attached(BaseObserver baseObserver)
        {
            _observers.Add(baseObserver);
        }

        public void Detached(BaseObserver baseObserver)
        {
            _observers.Remove(baseObserver);
        }

        public void Notification()
        {
            foreach (var item in _observers)
            {
                item.Update();
            }
        }
    }
}
