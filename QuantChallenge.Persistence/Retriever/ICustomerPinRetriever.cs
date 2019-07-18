using System.Collections.Generic;
using QuantChallenge.Persistence.UserDataProvider;

namespace QuantChallenge.Persistence.Retriever
{
    public interface ICustomerPinRetriever
    {
        IList<int> GetPinsForValidation(UserIdEnum userId);
    }
}