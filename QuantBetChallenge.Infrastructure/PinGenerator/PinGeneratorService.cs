using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using QuantBetChallenge.Core;
using QuantBetChallenge.Infrastructure.Validations.PinValidators;
using QuantBetChallenge.Infrastructure.Validations.PinValidators.Runner;
using QuantChallenge.Persistence.Retriever;
using QuantChallenge.Persistence.UserDataProvider;
using ValidationResult = QuantBetChallenge.Core.Validation.ValidationResult;

namespace QuantBetChallenge.Infrastructure.PinGenerator
{
    public class PinGeneratorService : IPinGeneratorService
    {
        private readonly ICustomerPinRetriever _customerPinRetriever;
        private readonly IPinValidationsRunner _pinValidationsRunner;

        public PinGeneratorService()
        :this(new CustomerPinRetriever(), new PinValidationsRunner())
        {
        }

        private PinGeneratorService(ICustomerPinRetriever customerPinRetriever, IPinValidationsRunner pinValidationsRunner)
        {
            _customerPinRetriever = customerPinRetriever;
            _pinValidationsRunner = pinValidationsRunner;
        }

        public StandardResponse<int?> GeneratePin(ICustomerDetails customerDetails)
        {
            int pin = GenerateRandomPin();
            IList<int> pastPins = _customerPinRetriever.GetPinsForValidation((UserIdEnum) customerDetails.Id);

            PinForValidationDto pinForValidationDto = new PinForValidationDto(pin, pastPins, customerDetails.BankAccountDetails.BankAccount, customerDetails.BankAccountDetails.SortCode);
            _pinValidationsRunner.ValidationContext = new ValidationContext(pinForValidationDto);

            IList<ValidationResult> validationResults = _pinValidationsRunner.Run();

            bool validationsfailed = validationResults.Any(v => !v.Success);

            if(validationsfailed)
                return new StandardResponse<int?>(false, null, validationResults.Where(v => !v.Success).Select(v => v.Message).ToList());

            return new StandardResponse<int?>(true, pin, null);
        }

        private int GenerateRandomPin()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }
    }
}
