using System;
using System.Collections.Generic;
using System.Linq;
using QuantBetChallenge.Core;
using QuantBetChallenge.Infrastructure;
using QuantBetChallenge.Infrastructure.PinGenerator;
using QuantBetChallenge.Infrastructure.Validations.PinValidators;
using QuantChallenge.Persistence.UserDataProvider;

namespace QuantBetChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            IPinGeneratorService pinGenerator = new PinGeneratorService();

            ICustomerDetails jane = CustomerDetailsProvider.Jane;

            StandardResponse<int?> response = pinGenerator.GeneratePin(jane);

            if(response.Success)
                Console.WriteLine($"Successfully created pin: {response.Result}");
            else
            {
                Console.WriteLine("Pin failed to generate. Please see below for more details");
                foreach (var errorMessage in response.ErrorMessages)
                    Console.WriteLine(errorMessage);
            }

            
        }
    }
}
