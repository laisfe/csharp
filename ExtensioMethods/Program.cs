using System;

namespace ExtensioMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 05, 4, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            Console.WriteLine();

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
