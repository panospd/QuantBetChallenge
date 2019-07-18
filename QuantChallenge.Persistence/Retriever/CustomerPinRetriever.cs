using System;
using System.Collections.Generic;
using System.Text;
using QuantChallenge.Persistence.UserDataProvider;

namespace QuantChallenge.Persistence.Retriever
{
    public class CustomerPinRetriever : ICustomerPinRetriever
    {
        public IList<int> GetPinsForValidation(UserIdEnum userId)
        {
            if (userId == UserIdEnum.Jack)
                return CustomerPinsProvider.JackPins.Pins;

            if (userId == UserIdEnum.Jane)
                return CustomerPinsProvider.JanePins.Pins;

            return new List<int>();
        }
    }
}
