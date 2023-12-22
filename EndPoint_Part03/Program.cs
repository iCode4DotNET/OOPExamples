using Models.Personel;
using SadrTools.Extension;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EndPoint_Part03
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
                Emails = new List<Email>
                {
                    new Email
                    {
                         ID = 1,
                         EmailAddress = "soroush@yahoo.com",
                         EmailProviderType = EnEmailProviderType.Yahoo
                    },
                    new Email
                    {
                         ID = 2,
                         EmailAddress = "soroush@microsoft.com",
                         EmailProviderType = EnEmailProviderType.Microsoft
                    },
                },
                Telephones = new List<Telephone>
                 {
                     new Telephone
                     {
                         ID = 1 ,
                         Number = "09121212121",
                         TelephoneType = EnTelephoneType.Mobile
                     }
                 }

            };

            var person2 = new Person
            {
                ID = 2,
                FirstName = "Ali",
                LastName = "Alavi",
                Grade = 18.98,
                SSN = "1231231232",
                BirthDate = new DateTime(2000, 1, 31),
                Gender = true,
                Telephones = new List<Telephone>
                 {
                     new Telephone
                     {
                         ID = 2 ,
                         Number = "888111222",
                         TelephoneType = EnTelephoneType.Office
                     }
                 }

            };

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(person1);

            Console.WriteLine(person2);

            Console.Clear();


            var people = SampleData.Personel.GetPeople();   

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            Console.ReadKey();
        }
    }
}
