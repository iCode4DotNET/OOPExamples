using System;

namespace Models.Shopping
{
    public class Customer : object
    {
        //public Customer()
        //{

        //}

        public Customer(string fullName)
        {
            ID = SadrTools.Utility.NumericHelper.GetRandom();
            FullName = fullName;
        }

        public int ID { get; }

        public string FullName { get; set; }


        public override string ToString()
        {
            return $"{ID} {FullName}";
        }
    }
        

}