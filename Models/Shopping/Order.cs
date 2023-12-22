using SadrTools.Extension;
using System;
using System.Collections.Generic;

namespace Models.Shopping
{
    public class Order
    {
        public Order()
        {
            ID = SadrTools.Utility.NumericHelper.GetRandom();
            OrderDetails = new List<OrderDetail>();
        }

        public int ID { get; }

        public DateTime OrderDate { get; set; }

        public Customer CustomerObject { get; set; }

        public List<OrderDetail>  OrderDetails { get; set; }

        public int TotalAmount
        {
            get
            {
                int sum = 0;
                foreach (var item in OrderDetails)
                {
                    sum += item.TotalRow;
                }
                return sum;
            }
        }


        public override string ToString()
        {
            return $"{ID} {CustomerObject} {OrderDate.ToPersianDate()} Total = {TotalAmount} Total Items = {OrderDetails.Count}\n";
        }
    }

}
