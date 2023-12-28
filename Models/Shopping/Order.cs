using SadrTools.Extension;
using System;
using System.Collections.Generic;

namespace Models.Shopping
{

    /// <summary>
    /// Invoice فاکتور
    /// </summary>
    public class Order
    {
        public Order()
        {
            ID = SadrTools.Utility.NumericHelper.GetRandom();
            OrderDetails = new List<OrderDetail>();
            Note = "با تشکر از خرید شما";
        }

        /// <summary>
        /// کلید فنی
        /// </summary>
        public int ID { get; }

        public DateTime OrderDate { get; set; }

        /// <summary>
        /// موجودیت مشتری
        /// </summary>
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


        /// <summary>
        /// کلید بیزینسی 
        /// </summary>
        public string OrderNo { get; set; }

        public string Note { get; set; }

       

        /// <summary>
        /// مبلغ کل قابل پرداخت
        /// </summary>
        public int TotalPriceToPay
        {
            get
            {
                var result = TotalPrice;

                if (CustomerObject is VIPCustomer)
                {
                    byte percent = (byte)(CustomerObject as VIPCustomer).MembershipType;
                    result -= ((result * percent) / 100);
                }

                return result;
            }
        }


        /// <summary>
        /// مبلغ کل
        /// </summary>
        public int TotalPrice
        {
            get
            {
                int result = 0;
                foreach (OrderDetail item in OrderDetails)
                {
                    result += item.TotalRow;
                }

                return result;
            }
        }


        public int Discount
        {
            get 
            {
                return TotalPrice - TotalPriceToPay;
            }
        }



        public override string ToString()
        {
            return $"{ID} {CustomerObject} {OrderDate.ToPersianDate()} Total = {TotalAmount} Total Items = {OrderDetails.Count}\n";
        }
    }

}
