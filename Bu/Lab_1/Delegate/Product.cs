using System;
using System.Collections.Generic;

namespace Bu.Lab_1.Delegate
{
    public class Product
    {
        List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Display()
        {
            Console.WriteLine("\nPorduct Parts");

            foreach (var item in parts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
