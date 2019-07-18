using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantBetChallenge.Infrastructure.Helpers
{
    public static class IntegerToIntArrayConverter
    {
        public static int[] GetDigits(int number)
        {
            return Array.ConvertAll(number.ToString().ToArray(), x => (int)x - 48);
        }
    }
}
