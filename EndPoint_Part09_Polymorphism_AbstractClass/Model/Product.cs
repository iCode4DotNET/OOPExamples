namespace EndPoint_Part09_Polymorphism_AbstractClass.Model
{
    internal abstract class Product
    {
        public int ID { get; set; }
        public abstract string Print();
    }

    internal class Book : Product
    {
        public Book()
        {
                
        }

        public string Name { get; set; }
        public string ISBN { get; set; }

        public override string Print()
        {
            return $"Abstract : {ID} {Name} {ISBN}";
        }

        public override string ToString()
        {
            return this.Print();
        }
    }

    internal class Car : Product
    {
        public Car()
        {

        }

        public string Name { get; set; }
        public int Year { get; set; }

        public override string Print()
        {
            return $"Abstract : {ID} {Name} {Year}";
        }

        public override string ToString()
        {
            return this.Print();
        }
    }
}

