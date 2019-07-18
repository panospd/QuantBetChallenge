using System;
using System.Collections.Generic;
using QuantBetChallenge.Core;

namespace QuantChallenge.Persistence.UserDataProvider
{
    public static class CustomerDetailsProvider
    {
        public static ICustomerDetails Jane => GetJane();
        public static ICustomerDetails Jack => GetJack();

        private static ICustomerDetails GetJane()
        {
            ICustomerPersonalDetails personalDetails = new CustomerPersonalDetails("Jane", DateTime.Now.AddYears(-29));
            IBankAccountDetails bankDetails = new BankAccountDetails("30-98-93", "23435332");

            return new CustomerDetails((int)UserIdEnum.Jane, personalDetails, bankDetails);
        }

        private static ICustomerDetails GetJack()
        {
            ICustomerPersonalDetails personalDetails = new CustomerPersonalDetails("Jack", DateTime.Now.AddYears(-35));
            IBankAccountDetails bankDetails = new BankAccountDetails("31-94-92", "12423432");

            return new CustomerDetails((int)UserIdEnum.Jack, personalDetails, bankDetails);
        }
    }
}
