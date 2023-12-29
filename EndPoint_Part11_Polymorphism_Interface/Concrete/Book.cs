using EndPoint_Part11_Polymorphism_Interface.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndPoint_Part11_Polymorphism_Interface.Concrete
{
    internal class Book : IProduct
    {
        public int ID { get ; set ; }

        public string Print()
        {
            return $"Interface : {ID} {Name} {ISBN}";
        }

        public string Name { get; set; }
        public string ISBN { get; set; }

    
        public override string ToString()
        {
            return this.Print();
        }
    }

    internal class Car : IProduct
    {
        public int ID { get; set; }

        public Car()
        {

        }

        public string Name { get; set; }
        public int Year { get; set; }

        public string Print()
        {
            return $"Interface : {ID} {Name} {Year}";
        }

        public override string ToString()
        {
            return this.Print();
        }
    }
}
