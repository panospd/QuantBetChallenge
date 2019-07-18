using System.Collections.Generic;
using QuantBetChallenge.Core;

namespace QuantChallenge.Persistence.UserDataProvider
{
    public static class CustomerPinsProvider
    {
        public static ICustomerPins JanePins => new CustomerPins((int)UserIdEnum.Jane, new List<int> { 1273, 4598, 2957, 4859 });
        public static ICustomerPins JackPins => new CustomerPins((int)UserIdEnum.Jack, new List<int> { 1273, 4598, 2957, 4859 });
    }
}