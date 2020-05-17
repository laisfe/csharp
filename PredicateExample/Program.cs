using System;
using PredicateExample.Entities;
using System.Collections.Generic;

namespace PredicateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //produto p tal qual p.price seja maior ou igual a 100
            // list.RemoveAll(p => p.Price >= 100.0);
            list.RemoveAll(ProductTest);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100;
        }
    }
}
