using System;
using System.Linq;
using QuantBetChallenge.Core.Validation;
using QuantBetChallenge.Infrastructure.Helpers;

namespace QuantBetChallenge.Infrastructure.Validations.PinValidators
{
    public class PinCannotBeZerosFollowedByTwoOnesValidator : PinValidator, IValidator
    {
        public override ValidationResult Validate()
        {
            IPinForValidationDto pinForValidationDto = ValidationContext.ObjectInstance as IPinForValidationDto;

            if (pinForValidationDto == null)
                throw new Exception("Object for validation is null");

            int[] pinDigits = StringDigitsToIntArrayConverter.GetDigits(pinForValidationDto.Pin);

            if (PinIs0011(pinDigits))
                return new ValidationResult(false, "Pin cannot be 0011.");

            return new ValidationResult(true, null);
        }

        private bool PinIs0011(int[] pinDigits)
        {
           return 
                  pinDigits[0] == 0 
                   && pinDigits[1] == 0
                   && pinDigits[2] == 1
                   && pinDigits[3] == 1;
        }
    }
}