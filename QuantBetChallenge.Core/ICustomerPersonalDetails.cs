using System;

namespace QuantBetChallenge.Core
{
    public interface ICustomerPersonalDetails
    {
        string Name { get; }
        DateTime DateOfBirth { get; }
    }
}