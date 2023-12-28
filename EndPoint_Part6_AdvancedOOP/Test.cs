using Models.Shopping;
using System;

namespace EndPoint_Part6_AdvancedOOP
{
    
    internal class A
    {
        public A() { }

        private int _myPrivateField;

        public int MyPublicProperty { get; set; }
        protected int MyProtectedPropert { get; set; }

        public virtual void F1() { }
        public void F2() { }


    }

    class B : A
    {
        public B()
        {
            this.MyPublicProperty = 1;
            this.MyProtectedPropert = 2;
            //this._myPrivateField = 3; //  'A._myPrivateField' is inaccessible due to its protection level
            //this.MyProtectedPropert2 = 2;  // Does not Contain
        }


        public override void F1()
        {
            base.F1();
        }


        public new void F2()
        {

        }
    }


    class C : B
    {
        public C() { }

        public sealed override void F1()
        {
            base.F1();

            base.F2();

            this.F2();
        }
    }

    //Class 'D' cannot have multiple base classes: 'A' and 'B'	
    //class D : A,B { }

    class D : C
    {
        // کلاس سی کاری کند که کلاس دی نتواند 
        // override کند 

        /*
        public override void F1()
        {
            base.F1();
        }
        */
        //cannot override inherited member 'C.F1()' because it is sealed

    }

    /*
    class D0  : D
    {
        override  .....
    }
    */


    /*
    class D1 : D2 { }
    class D2 : D1 { }
    */


    public class E
    {
        public E(int alaki)
        {
                
        }

        private E()
        {
            //D d = new C(); // NOT OK ( Which child ? ) 
            //D d = (D)new C(); // OK 

            C c = new D(); // OK ( There is One Parent ! ) 

            Customer c1 = new VIPCustomer("", EnMembershipType.CIP);

            //E e1 = new E();
        }

        void F1()
        {
            E e1 = new E();
        }

        public class F
        {
            public F()
            {
                E e = new E();
            }
        }
    }


  
    class G
    {
        public G()
        {
            Console.WriteLine($"Ctor in Class G : {Guid.NewGuid()}");
        }

        static G()
        {
            Console.WriteLine($"Static Ctor in Class G : {Guid.NewGuid()}");
        }


        public static void F1()
        {
            Console.WriteLine($"Static Method in Class G : {Guid.NewGuid()}");
        }
    }

    public class H
    {
        public H()
        {

        }

        public void H1()
        {
            System.Diagnostics.Debug.WriteLine("H _ H1");
        }
    }


    public class I : H
    {
        public I()
        {

        }

        public void I1()
        {
            System.Diagnostics.Debug.WriteLine("I _ I1 _ B4");
            //this.H1();
            H1();

            base.H1();
            System.Diagnostics.Debug.WriteLine("I _ I1 _ After");
        }


        public void H1(int number)
        {
            System.Diagnostics.Debug.WriteLine("I _ H1 _ " + number);

        }

        public new void H1()
        {
            System.Diagnostics.Debug.WriteLine("I _ new H1");
        }


    }

    struct J
    {
        //public J(){}

        public J(int input)
        {
                 
        }
    }

    //struct K : J{ } // Type 'J' in interface list is not an interface
    //class K : J{}  // 'K': cannot derive from sealed type 'J'	


    //https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/choosing-between-class-and-struct

}