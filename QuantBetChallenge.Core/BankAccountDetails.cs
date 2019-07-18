using System;
using System.Collections.Generic;

namespace QuantBetChallenge.Core
{
    public class BankAccountDetails : IBankAccountDetails
    {
        public BankAccountDetails(string sortCode, string bankAccount)
        {
            SortCode = sortCode;
            BankAccount = bankAccount;
        }

        public string SortCode { get;}
        public string BankAccount { get;}
    }
}