using System;

namespace EndPoint_Part6_AdvancedOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //E e1 = new E();

            //E.F f1 = new E.F();


            //G g1 = new G();
            //G g2 = new G();
            //G g3 = new G();

            //G.F1();
            //G.F1();
            //G.F1();

            //Console.ReadKey();

            //Console.Clear();

            H h = new H();
            h.H1();

            I i = new I();
            i.H1();
            i.H1(666);
            i.I1();

            Console.ReadKey();

        }
    }
}
