namespace EndPoint_Part07_Polymorphism_Inheritance_VirtualMethod.Model
{
    internal class Product
    {
        public int ID { get; set; }

        /// <summary>
        /// متد پرینت داخل کلاس Product
        /// </summary>
        /// <returns></returns>
        public virtual string Print()
        {
            return $"ID = {ID} ";
        }
    }

    internal class Book : Product
    {
        public string Title { get; set; }
        public string ISBN { get; set; }


        public override string Print()
        {
            var result = base.Print();
            result += $"Title = {Title} ISBN = {ISBN}";
            return result;
        }
    }


    internal class Car : Product
    {
        public string Title { get; set; }
        public int ModelYear { get; set; }

        public override string Print()
        {
            var result = base.Print();
            result += $"Title = {Title} Year = {ModelYear}";
            return result;
        }
    }

}