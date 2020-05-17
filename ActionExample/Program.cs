using System;
using ActionExample.Entities;
using System.Collections.Generic;

namespace ActionExample
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

            //Action<Product> act = p => { p.Price += p.Price * 0.1; };

            /**
            Action<Product> act = UpdatePrice;
            list.ForEach(act);
            */

            /**
            aplica a função updatePrice a todos os elementos da lista
            list.ForEach(UpdatePrice);
            */

            list.ForEach(p => { p.Price += p.Price * 0.1; });

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        /**
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
        */
    }
}
