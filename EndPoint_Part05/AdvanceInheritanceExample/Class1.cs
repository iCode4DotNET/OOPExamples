using System.Threading;

namespace EndPoint_Part05.AdvanceInheritanceExample
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

        public override void F1()
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

        public override void F1()
        {
            base.F1();
        }
    }

}


