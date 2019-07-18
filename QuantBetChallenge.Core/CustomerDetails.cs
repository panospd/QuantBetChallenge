namespace QuantBetChallenge.Core
{
    public class CustomerDetails : ICustomerDetails
    {
        public CustomerDetails(int id, ICustomerPersonalDetails personalDetails, IBankAccountDetails bankAccountDetails)
        {
            Id = id;
            PersonalDetails = personalDetails;
            BankAccountDetails = bankAccountDetails;
        }

        public int Id { get;}
        public ICustomerPersonalDetails PersonalDetails { get; }
        public IBankAccountDetails BankAccountDetails { get; }
    }
}
