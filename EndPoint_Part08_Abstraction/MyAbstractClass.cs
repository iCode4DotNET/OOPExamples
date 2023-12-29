namespace EndPoint_Part08_Abstraction
{
    internal abstract class MyAbstractClass
    {
        public MyAbstractClass()
        {

        }

        //F1 cannot declare a body because it is marked abstract
        //public abstract void F1()  { }

        public abstract void F2();

        public void F3() { }
        public virtual void F4() { }

        public static void F5() { }

        public int MyProperty { get; set; }

        public abstract int MyProperty2 { get; set; }

    }

    public class MyNormalClass
    {
        //F2()' is abstract but it is contained in non-abstract type
        //public abstract void F2();
    }


    internal class ChildClass : MyAbstractClass
    {
        public override int MyProperty2 { get; set; }

        public override void F2()
        {
            throw new System.NotImplementedException();
        }

        public override void F4()
        {
            base.F4();
        }
    }


    internal abstract class MyAbstractClass2 : MyAbstractClass
    {
        public abstract void Fx();
        //public override abstract void F2();
        //public new abstract void F2();
    }

    internal class ChildClass2 : MyAbstractClass2//, MyNormalClass
    {
        public override int MyProperty2 { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public override void F2()
        {
            throw new System.NotImplementedException();
        }

      
        public override void Fx()
        {
            throw new System.NotImplementedException();
        }
    }

}
