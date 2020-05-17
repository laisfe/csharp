﻿using System;
using System.Linq;
using System.Collections.Generic;
using FuncExample.Entities;

namespace FuncExample
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

            //Func<Product, string> func = p => p.Name.ToUpper();

            //List<String> result = list.Select(NameUpper).ToList();

            List<String> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        /**
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
        */
    }
}
