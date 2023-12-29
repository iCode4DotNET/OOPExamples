namespace EndPoint_Part10_Interface.Contract
{
    //internal interface MyInterface{} // Naming Rule Violation : Missing Prefix I

    // قرارداد
    // Contract 
    // در یک جمله 
    // view : virtual table whose...
    // interface : برای کاهش وابستگی میباشد
    // High Coheision , Loosley Couple
    // سه حالت شخصیتی




    internal interface IProduct
    {
        //public void F1(){}

        //The modifier 'public',..... is not valid for this item in C# 7.3. Please use language version '8.0' or greater.

        //public void F1();    
        //protected void F1();

         void F1();
         int MyProperty { get; set; }

    }


    public interface IDoSomething1
    {
        //in the world of computer programming,
        //"foo" and "bar" are commonly used as generic examples
        //of the names of files, users, programs, classes, hosts, etc. 

        void Foo();
        void Bar();
    }

    public interface IDoSomething2 : IDoSomething1
    {
        void Foo2();
        void Bar2();
    }


    public interface IDoSomething3
    {
        void Foo();
        void Bar2();
    }

}