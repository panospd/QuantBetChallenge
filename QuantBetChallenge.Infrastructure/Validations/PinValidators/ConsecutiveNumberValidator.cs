using System;
using System.Collections.Generic;
using System.Linq;
using QuantBetChallenge.Core;
using QuantBetChallenge.Core.Validation;
using QuantBetChallenge.Infrastructure.Helpers;

namespace QuantBetChallenge.Infrastructure.Validations.PinValidators
{
    public class ConsecutiveNumberValidator : PinValidator, IValidator
    {
        public override ValidationResult Validate()
        {
            IPinForValidationDto pinForValidationDto = ValidationContext.ObjectInstance as IPinForValidationDto;

            if (pinForValidationDto == null)
                throw new Exception("Object for validation is null");

            int[] pin = IntegerToIntArrayConverter.GetDigits(pinForValidationDto.Pin);

            if (MoreThanTwoConsecutive(pin))
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