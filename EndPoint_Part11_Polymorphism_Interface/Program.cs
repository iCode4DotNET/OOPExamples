using EndPoint_Part11_Polymorphism_Interface.Concrete;
using EndPoint_Part11_Polymorphism_Interface.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndPoint_Part11_Polymorphism_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<IProduct>();

            products.Add(new Book()
            {
                ID = 1,
                ISBN = "",
                Name = "Test",
            });


            products = new List<IProduct>
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

            foreach (IProduct item in products)
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
