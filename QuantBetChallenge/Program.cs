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


            bool pinSuccessfullyCreated = GeneratePinProcessRun(pinGenerator, jane);

            while (!pinSuccessfullyCreated)
            {
                pinSuccessfullyCreated = GeneratePinProcessRun(pinGenerator, jane);
            }
        }

        private static bool GeneratePinProcessRun(IPinGeneratorService pinGenerator, ICustomerDetails customerDetails)
        {
            StandardResponse<string> response = pinGenerator.GeneratePin(customerDetails);

            if (response.Success)
            {
                Console.WriteLine($"Successfully created pin: {response.Result}");
                return true;
            }

            Console.WriteLine("Pin failed to generate. Please see below for more details");
            foreach (var errorMessage in response.ErrorMessages)
                Console.WriteLine(errorMessage);

            return false;
        }
    }
}
