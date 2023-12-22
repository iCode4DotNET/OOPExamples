using Basic = Models.Personel;
using Adv = Models.Personel_Adv;
using System;
using System.Collections.Generic;

namespace SampleData
{
    public static class Personel
    {
        public static List<Basic.Person> GetPeople()
        {
            var person1 = new Basic.Person
            {
                ID = 1,
                FirstName = "Soroush",
                LastName = "Sadr",
                Grade = 18.98,
                SSN = "1231231231",
                BirthDate = new DateTime(1984, 1, 31),
                Gender = true,
                Emails = new List<Basic.Email>
                {
                    new Basic.Email
                    {
                         ID = 1,
                         EmailAddress = "soroush@yahoo.com",
                         EmailProviderType = Basic.EnEmailProviderType.Yahoo
                    },
                    new Basic.Email
                    {
                         ID = 2,
                         EmailAddress = "soroush@microsoft.com",
                         EmailProviderType = Basic.EnEmailProviderType.Microsoft
                    },
                },
                Telephones = new List<Basic.Telephone>
                 {
                     new Basic.Telephone
                     {
                         ID = 1 ,
                         Number = "09121212121",
                         TelephoneType = Basic.EnTelephoneType.Mobile
                     }
                 }

            };

            var person2 = new Basic.Person
            {
                ID = 2,
                FirstName = "Ali",
                LastName = "Alavi",
                Grade = 18.98,
                SSN = "1231231232",
                BirthDate = new DateTime(2000, 1, 31),
                Gender = true,
                Telephones = new List<Basic.Telephone>
                 {
                     new Basic.Telephone
                     {
                         ID = 2 ,
                         Number = "888111222",
                         TelephoneType = Basic.EnTelephoneType.Office
                     }
                 }

            };

            var person3 = new Basic.Person
            {
                ID = 3,
                FirstName = "arezoo",
                LastName = "Alavi",
                Grade = 18.98,
                SSN = "1231231233",
                BirthDate = new DateTime(2002, 1, 31),
                Gender = false,
                Emails = new List<Basic.Email> 
                {
                    new Basic.Email
                    {
                        ID = 3 ,
                        EmailAddress = "arezoo@gmail.com", 
                         EmailProviderType = Basic.EnEmailProviderType.Google
                    }
                }
            };

            var people = new List<Basic.Person> { person1, person2, person3 };  

            people.Add(person1);

            return people;

        }

        
        public static Adv.Person[] GetPeopleYasamin()
        {
            var person1 = new Adv.Person
            {
               
                FirstName = "Soroush",
                LastName = "Sadr",
                Grade = 18.98,
                SSN = "1231231231",
                BirthDate = new DateTime(1984, 1, 31),
                Gender = true,
                Emails = new List<Adv.Email>
                {
                    new Adv.Email
                    {
                         EmailAddress = "soroush@yahoo.com",
                         EmailProviderType = Adv.EnEmailProviderType.Yahoo
                    },
                    new Adv.Email
                    {
                         EmailAddress = "soroush@microsoft.com",
                         EmailProviderType = Adv.EnEmailProviderType.Microsoft
                    },
                },
                Telephones = new List<Adv.Telephone>
                 {
                     new Adv.Telephone
                     {
                         Number = "09121212121",
                         TelephoneType = Adv.EnTelephoneType.Mobile
                     }
                 }

            };

            var person2 = new Adv.Person
            {
                FirstName = "Ali",
                LastName = "Alavi",
                Grade = 18.98,
                SSN = "1231231232",
                BirthDate = new DateTime(2000, 1, 31),
                Gender = true,
                Telephones = new List<Adv.Telephone>
                 {
                     new Adv.Telephone
                     {
                         Number = "888111222",
                         TelephoneType = Adv.EnTelephoneType.Office
                     }
                 }

            };

            var person3 = new Adv.Person
            {
                FirstName = "arezoo",
                LastName = "Alavi",
                Grade = 18.98,
                SSN = "1231231233",
                BirthDate = new DateTime(2002, 1, 31),
                Gender = false,
                Emails = new List<Adv.Email>
                {
                    new Adv.Email
                    {
                        EmailAddress = "arezoo@gmail.com",
                        EmailProviderType = Adv.EnEmailProviderType.Google
                    }
                }
            };

            return new Adv.Person[] { person1, person2, person3 };

        }


        //'ToString': cannot declare instance members in a static class SampleData
        /*
        public override string ToString()
        {
            return base.ToString();
        }
        */

    }
}
