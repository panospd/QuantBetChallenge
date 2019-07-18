using System.Collections.Generic;

namespace QuantBetChallenge.Core
{
    public interface ICustomerPins
    {
        int UserId { get; }
        IList<string> Pins { get; }
    }
}