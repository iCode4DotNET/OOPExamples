using EndPoint_Part09_Polymorphism_AbstractClass.Model;
using System;
using System.Collections.Generic;

namespace EndPoint_Part09_Polymorphism_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Book
                {
                     ID = 1,
                      ISBN = "isbn 1",
                       Name = "Title 1",
                },
                new Car
                {
                     ID = 2,
                      Year = 2001,
                       Name = "CAR 1"
                },
                new Book
                {
                     ID = 3,
                      ISBN = "isbn 2",
                       Name = "Title 2",
                },
                new Car
                {
                     ID = 4,
                      Year = 2002,
                       Name = "CAR 2"
                },
                new Book
                {
                     ID = 5,
                      ISBN = "isbn 3",
                       Name = "Title 3",
                },
            };

            foreach (var item in products)
            {
                if (item is Book)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Magenta;


                Console.WriteLine(item.Print());
            }

            Console.ReadKey();
        }
    }
}
