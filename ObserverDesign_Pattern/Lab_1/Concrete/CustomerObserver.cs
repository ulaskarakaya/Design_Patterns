﻿using ObserverDesign_Pattern.Lab_1.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesign_Pattern.Lab_1.Concrete
{
    public class CustomerObserver : BaseObserver
    {
        public override void Update()
        {
            Console.WriteLine("Message to customer: Product was changed..!");
        }
    }
}
