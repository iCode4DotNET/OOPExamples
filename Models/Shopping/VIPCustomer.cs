namespace Models.Shopping
{
    // کارمند شامل فقط اطلاعات مشترک بین همه انواع کارمند ها
    // رسمی - قراردادی - پیمانی - ساعتی - پروژه ای -  مشاوره

    //  Derived Class : BaseClass
    //  Child : Parent

    // Inheritance : is-a : VIP Customer is a Customer
    //                      Race-Car is a Car
    //                      Employee is a Person

    public class VIPCustomer : Customer
    {
        public VIPCustomer(string fullName,EnMembershipType membershipType) : base(fullName) 
        {
            MembershipType = membershipType;  
        }

        public EnMembershipType  MembershipType { get; set; }

    }

    //'VeryForeignCustomer': cannot derive from sealed type 'ForeignCustomer'	
    //public class VeryForeignCustomer : ForeignCustomer { }

}