using System;
using System.Collections.Generic;
using System.Linq;
using QuantBetChallenge.Core;
using QuantBetChallenge.Infrastructure;
using QuantBetChallenge.Infrastructure.PinGenerator;
using QuantBetChallenge.Infrastructure.Validations.PinValidators;

namespace QuantBetChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var pinGenerator = new PinGeneratorService();

            StandardResponse<int?> response = pinGenerator.GeneratePin(new CustomerDetails(1, new CustomerPersonalDetails("sa", DateTime.Now),
                new BankAccountDetails("12-34-67", "12656745")));

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
