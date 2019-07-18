using System.Linq;

namespace QuantBetChallenge.Infrastructure.Helpers
{
    public static class StringDigitsToIntArrayConverter
    {
        public static int[] GetDigits(string number)
        {
            return number.Select(ch => ch - '0').ToArray();
        }
    }
}
