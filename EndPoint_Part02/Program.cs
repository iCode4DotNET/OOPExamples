using Models.Personel;
using System;

namespace EndPoint_Part02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person
            {
                ID = 1,
                FirstName = "Soroush",
                LastName = "Sadr",
                Grade = 18.98,
                SSN = "1231231231",
                BirthDate = new DateTime(1984, 1, 31),
                Gender = true,
                 
            };


            var person2 = new Person();
            Console.WriteLine(person2);

            person2.BirthDate = new DateTime(2020, 1, 1);
            Console.WriteLine(person2);

            var person3 = new Person("ali","rezaee");

            var person4 = new Person(firstName:"soroush", lastName:"soroush");

            var date = new DateTime();


            Console.ReadKey();
        }
    }
}
