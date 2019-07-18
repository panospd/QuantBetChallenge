using System;
using System.Collections.Generic;

namespace QuantBetChallenge.Core
{
    public interface IBankAccountDetails
    {
        string SortCode { get; }
        string BankAccount { get; }
    }
}