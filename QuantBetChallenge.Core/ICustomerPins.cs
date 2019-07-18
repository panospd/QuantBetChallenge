using System.Collections.Generic;

namespace QuantBetChallenge.Core
{
    public interface ICustomerPins
    {
        int UserId { get; }
        IList<int> Pins { get; }
    }
}