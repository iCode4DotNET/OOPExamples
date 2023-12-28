namespace Models.Shopping
{
    /// <summary>
    /// InvoiceItem اقلام فاکتور
    /// </summary>
    public class OrderDetail
    {
        public OrderDetail()
        {
            ID = SadrTools.Utility.NumericHelper.GetRandom();
        }

        public int ID { get; }

        public Order OrderObject { get; set; }

        public Product  ProductObject { get; set; }

        public byte Qty { get; set; }

        /// <summary>
        /// مجموع یک ردیف از کل سفارش
        /// </summary>
        public int TotalRow
        {
            get 
            {
                return ProductObject.Price * Qty;
            }
        }

        public override string ToString()
        {
            return $"{ID} {ProductObject} {Qty} {TotalRow}\n";
        }

    }
}