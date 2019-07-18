using System;
using QuantBetChallenge.Core.Validation;

namespace QuantBetChallenge.Infrastructure.Validations.PinValidators
{
    public class PinContainedInSortCodeOrBankAccountValidator : PinValidator, IValidator
    {
        public override ValidationResult Validate()
        {
            IPinForValidationDto pinForValidationDto = ValidationContext.ObjectInstance as IPinForValidationDto;

            if (pinForValidationDto == null)
                throw new Exception("Object for validation is null");

            if (PinIsContainedInBankAccountOrSortCode(pinForValidationDto))
                return new ValidationResult(false, "Pin cannot be contained in bank account or sort code.");
            
            return new ValidationResult(true, null);
        }

        private bool PinIsContainedInBankAccountOrSortCode(IPinForValidationDto pinForValidationDto)
        {
            string pin = pinForValidationDto.Pin.ToString();

            bool bankAccountContainsPin = pinForValidationDto.BankAccount.Contains(pin);
            bool sortCodeContains = pinForValidationDto.SortCode.Replace("-", "").Contains(pin);

            if (bankAccountContainsPin || sortCodeContains)
                return true;

            return false;
        }
    }
}