using EndPoint_Part07_Polymorphism_Inheritance_VirtualMethod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndPoint_Part07_Polymorphism_Inheritance_VirtualMethod
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
                       Title = "Title 1",
                },
                new Car
                {
                     ID = 2,
                      ModelYear = 2001,
                       Title = "CAR 1"
                },
                new Book
                {
                     ID = 3,
                      ISBN = "isbn 2",
                       Title = "Title 2",
                },
                new Car
                {
                     ID = 4,
                      ModelYear = 2002,
                       Title = "CAR 2"
                },
                new Book
                {
                     ID = 5,
                      ISBN = "isbn 3",
                       Title = "Title 3",
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
