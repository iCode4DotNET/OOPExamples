using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndPoint_Part01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Personel.Person obj1 = new Models.Personel.Person();
            obj1.ID = 1;
            obj1.FirstName = "Soroush";
            obj1.LastName = "Sadr";
            obj1.Grade = 18.98;
            obj1.SSN = "1231231231";
            obj1.BirthDate = new DateTime(1984, 1, 31);
            obj1.Gender = true;


            Models.Personel.Person obj2 = new Models.Personel.Person();
            obj2.ID = 2;
            obj2.FirstName = "Ali";
            obj2.LastName = "Sadr";
            obj2.Grade = 18.98;
            obj2.SSN = "1231231232";
            obj2.BirthDate = new DateTime(2000, 1, 31);
            obj2.Gender = true;

            Models.Personel.Person obj3 = new Models.Personel.Person();
            obj3.ID = 3;
            obj3.FirstName = "aa";
            obj3.LastName = "bb";
            obj3.Grade = 18.98;
            obj3.SSN = "1231231232";
            obj3.BirthDate = new DateTime(2000, 1, 31);
            obj3.Gender = true;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{obj1.ID} {obj1.FirstName} {obj1.LastName} {obj1.BirthDate} {obj1.SSN}");

            Console.WriteLine($"{obj2.ID} {obj2.FirstName} {obj2.LastName} {obj2.BirthDate} {obj2.SSN}");

            Console.WriteLine($"{obj3.ID} {obj3.FirstName} {obj3.LastName} {obj3.BirthDate} {obj3.SSN}");

            var data1 = obj1.GetInformation();
            Console.WriteLine(data1);

            Console.WriteLine(obj2.GetInformation());
            Console.WriteLine(obj3.GetInformation());


           // SadrTools.Utility.DateHelper helper1 = new SadrTools.Utility.DateHelper();

            var emrooz =  SadrTools.Utility.DateHelper.ToPersianDate(DateTime.Now);

            // متد استاتیک از طریق نام کلاس فراخوانی میشود
            // نتیجه آن هیچ ربطی به کسی یا چیزی یا جایی که آن را فراخوانی میکند ندارد

            // پس کل کلاس رو هم استاتیک تعریف میکنیم که نتوان از آن آبجکت ساخت

            // متد های غیر استاتیک از طریق آبجکتی که از کلاس آن ساختیم فراخوانی میشود
            // و کاملا خروجی آن بر اساس آبجکت فراخوانی کننده میباشد


            Console.WriteLine(obj1.ToString());
            Console.WriteLine(obj2.ToString());
            Console.WriteLine(obj3.ToString());

            Console.WriteLine("---------------------");

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(obj3);


            Console.WriteLine(obj3.PersianBirthDate);
            Console.WriteLine(obj3.Age);

            //obj3.Age = 12;

            Console.ReadKey();

        }
    }
}
