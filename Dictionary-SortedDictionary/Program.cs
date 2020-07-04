using System;
using System.Collections.Generic;

namespace Dictionary_SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            //       key        value
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "912345678";
            cookies["phone"] = "998765432";

            Console.WriteLine("Email: " + cookies["email"]);

            Console.WriteLine();

            //dictionary nao aceita valores repetidos entao ele ira sobrescrever o primeiro valor de phone pelo segundo valor
            Console.WriteLine("Phone: " + cookies["phone"]);

            Console.WriteLine();

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine();

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine();

            Console.WriteLine("ALL COOKIES");
            foreach (KeyValuePair<string, string> item in cookies) //tambem pode ser foreach (var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
