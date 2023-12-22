using System;

namespace EndPoint_Part04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = SampleData.Personel.GetPeopleYasamin();

            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var person in people) 
            {
                Console.WriteLine(person);
            }
            
            Console.ReadKey();
        }
    }
}
