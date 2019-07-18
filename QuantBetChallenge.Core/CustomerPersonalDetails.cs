using System;

namespace QuantBetChallenge.Core
{
    public class CustomerPersonalDetails : ICustomerPersonalDetails
    {
        public CustomerPersonalDetails(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public string Name { get; }
        public DateTime DateOfBirth { get; }
    }
}