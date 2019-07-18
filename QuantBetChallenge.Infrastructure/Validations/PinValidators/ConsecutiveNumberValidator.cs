using System;
using System.Linq;
using QuantBetChallenge.Core.Validation;

namespace QuantBetChallenge.Infrastructure.Validations.PinValidators
{
    public class ConsecutiveNumberValidator : PinValidator, IValidator
    {
        public override ValidationResult Validate()
        {
            IPinForValidationDto pinForValidationDto = ValidationContext.ObjectInstance as IPinForValidationDto;

            if (pinForValidationDto == null)
                throw new Exception("Object for validation is null");

            int[] pinDigits = pinForValidationDto.Pin.Select(ch => ch - '0').ToArray();

            if (MoreThanTwoConsecutive(pinDigits))
                return new ValidationResult(false, "Pin contains more than two consecutive numbers.");

            return new ValidationResult(true, null);
        }

        private bool MoreThanTwoConsecutive(int[] digits)
        {
            if (digits[0] == digits[1] && digits[0] == digits[2])
                return true;

            if (digits[1] == digits[2] && digits[1] == digits[3])
                return true;

            return false;
        }
    }
}