namespace QuantBetChallenge.Core
{
    public interface ICustomerDetails
    {
        int Id { get; }
        ICustomerPersonalDetails PersonalDetails { get; }
        IBankAccountDetails BankAccountDetails { get; }
    }
}