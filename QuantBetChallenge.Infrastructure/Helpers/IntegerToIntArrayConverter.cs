using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantBetChallenge.Infrastructure.Helpers
{
    public static class IntegerToIntArrayConverter
    {
        public static int[] GetDigits(string number)
        {
            return number.Select(ch => ch - '0').ToArray();
        }
    }
}
