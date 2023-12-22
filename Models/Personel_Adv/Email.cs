namespace Models.Personel_Adv
{
    /// <summary>
    /// موجودیت اطلاعات تماس
    /// </summary>
    public class Email
    {
        public Email()
        {
            EmailAddress = "test@test.ir";
            EmailProviderType = EnEmailProviderType.Other;
        }

        public int ID 
        {
            get
            {
                return SadrTools.Utility.NumericHelper.GetRandom();
            }
        }

        public string EmailAddress { get; set; }

        public EnEmailProviderType EmailProviderType { get; set; }

        public override string ToString()
        {
            return $"{ID} {EmailAddress} {EmailProviderType}\n";
        }
    }

}
