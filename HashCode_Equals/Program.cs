using HashCode_Equals.Entities;
using System;

namespace HashCode_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b); //retorna false pq a referência de memória dos dois objetos são diferentes
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
