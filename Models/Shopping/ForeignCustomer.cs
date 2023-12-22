namespace Models.Shopping
{
    public sealed class ForeignCustomer : VIPCustomer
    {
        public ForeignCustomer(string fullName, EnMembershipType membershipType, string countryName) : base(fullName, membershipType)
        {
            CountryName = countryName;
        }

        public string CountryName  { get; set; }
    }

    //'VeryForeignCustomer': cannot derive from sealed type 'ForeignCustomer'	
    //public class VeryForeignCustomer : ForeignCustomer { }

}