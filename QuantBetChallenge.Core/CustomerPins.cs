using System.Collections.Generic;

namespace QuantBetChallenge.Core
{
    public class CustomerPins : ICustomerPins
    {
        public CustomerPins(int userId, IList<int> pins)
        {
            UserId = userId;
            Pins = pins ?? new List<int>();
        }

        public int UserId { get; }
        public IList<int> Pins { get; }
    }
}