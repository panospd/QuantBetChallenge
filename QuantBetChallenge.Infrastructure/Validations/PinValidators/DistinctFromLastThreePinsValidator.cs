using System;
using QuantBetChallenge.Core;
using QuantBetChallenge.Core.Validation;
using static System.Int32;

namespace QuantBetChallenge.Infrastructure.Validations.PinValidators
{
    public class DistinctFromLastThreePinsValidator : PinValidator, IValidator
    {
        public override ValidationResult Validate()
        {
            IPinForValidationDto pinForValidationDto = ValidationContext.ObjectInstance as IPinForValidationDto;

            if (pinForValidationDto == null)
                throw new Exception("Object for validation is null");

            if (pinForValidationDto.PastPins.Contains(pinForValidationDto.Pin))
                return new ValidationResult(false, "Pin has already been used in the past.");

            return new ValidationResult(true, null);
        }
    }
}