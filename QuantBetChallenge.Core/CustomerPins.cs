using System.Collections.Generic;

namespace QuantBetChallenge.Core
{
    public class CustomerPins : ICustomerPins
    {
        public CustomerPins(int userId, IList<string> pins)
        {
            UserId = userId;
            Pins = pins ?? new List<string>();
        }

        public int UserId { get; }
        public IList<string> Pins { get; }
    }
}