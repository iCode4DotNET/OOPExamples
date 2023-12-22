namespace Models.Personel
{
    /// <summary>
    /// موجودیت اطلاعات تماس
    /// </summary>
    public class Telephone
    {

        public Telephone()
        {
            ID = 0;
            Number = "111111111";
            TelephoneType = EnTelephoneType.Other;
        }

        public int ID { get; set; }

        public string Number { get; set; }

        public EnTelephoneType  TelephoneType { get; set; }

        public override string ToString()
        {
            return $"{ID} {Number} {TelephoneType}\n";
        }
    }

}
