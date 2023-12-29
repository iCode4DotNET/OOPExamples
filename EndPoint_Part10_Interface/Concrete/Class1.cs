using EndPoint_Part10_Interface.Contract;

namespace EndPoint_Part10_Interface.Concrete
{

    internal class MyClass { }

    // Base class 'MyClass' must come before any interfaces

    //internal class MyConcreteClass : IProduct , MyClass
    internal class MyConcreteClass : MyClass, IProduct
    {
        public int MyProperty { get; set; }

        public void F1()
        {
            throw new System.NotImplementedException();
        }
    }

    class MyClass2 : IDoSomething1, IDoSomething2, IDoSomething3
    {
        public void Bar()
        {
            throw new System.NotImplementedException();
        }

        public void Bar2()
        {
            throw new System.NotImplementedException();
        }

        public void Foo()
        {
            throw new System.NotImplementedException();
        }

        public void Foo2()
        {
            throw new System.NotImplementedException();
        }
    }

    class MyClass3 : IDoSomething1, IDoSomething2, IDoSomething3
    {
        void IDoSomething1.Bar()
        {
            throw new System.NotImplementedException();
        }

        void IDoSomething2.Bar2()
        {
            throw new System.NotImplementedException();
        }

        void IDoSomething3.Bar2()
        {
            throw new System.NotImplementedException();
        }

        void IDoSomething1.Foo()
        {
            throw new System.NotImplementedException();
        }

        void IDoSomething3.Foo()
        {
            throw new System.NotImplementedException();
        }

        void IDoSomething2.Foo2()
        {
            throw new System.NotImplementedException();
        }
    }

}
