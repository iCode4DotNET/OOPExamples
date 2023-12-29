using EndPoint_Part10_Interface.Contract;
using EndPoint_Part10_Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndPoint_Part10_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IProduct product = new IProduct();

            var people = new List<Person>
            {
                new Person(1,"AAA1","BBB1",DateTime.Now.AddYears(-10)),
                new Person(2,"AAA2","BBB2",DateTime.Now.AddYears(-9)),
                new Person(3,"AAA3","BBB3",DateTime.Now.AddYears(-8)),
                new Person(4,"AAA4","BBB4",DateTime.Now.AddYears(10)),
                new Person(5,"AAA5","BBB5",DateTime.Now.AddYears(9)),
                new Person(7,"AAA7","BBB7",new DateTime(2000,1,1)),
                new Person(6,"AAA6","BBB6",new DateTime(2000,1,1)),            
            };

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            Console.ReadKey();  

            //people.Sort(); // Error

            people.Sort(new Person.SortByBirthDate());

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            Console.ReadKey();
        }
    }
}
