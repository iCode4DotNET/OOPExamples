using System;
using System.Collections;
using System.Collections.Generic;

namespace EndPoint_Part10_Interface.Model
{
    internal class Person
    {
        public Person(int id, string name, string family, DateTime birthDate)
        {
            ID = id;
            Name = name;
            Family = family;
            BirthDate = birthDate;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{ID} {Name} {BirthDate}";
        }

        internal class SortByBirthDate : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return x.BirthDate.CompareTo(y.BirthDate);    
            }
        }

    }
}
