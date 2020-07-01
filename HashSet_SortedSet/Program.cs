using System;
using System.Collections.Generic;

namespace HashSet_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine("HashSet contains Notebook: " + set.Contains("Notebook"));

            Console.Write("Print HashSet: ");

            foreach (String p in set)
            {
                Console.Write(p + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            SortedSet<int> a = new SortedSet<int>() { 10, 0, 2, 4, 5, 6, 8 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            Console.Write("Print SortedSet A: ");
            PrintCollection(a);

            //union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            Console.Write("Union: ");
            PrintCollection(c);

            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            Console.Write("Intersection: ");
            PrintCollection(d);

            //difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            Console.Write("Difference: ");
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
