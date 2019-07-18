using System;
using System.Linq;
using QuantBetChallenge.Core.Validation;
using QuantBetChallenge.Infrastructure.Helpers;

namespace QuantBetChallenge.Infrastructure.Validations.PinValidators
{
    public class PinCannotBeFourConsecutiveZerosValidator : PinValidator, IValidator
    {
        public override ValidationResult Validate()
        {
            IPinForValidationDto pinForValidationDto = ValidationContext.ObjectInstance as IPinForValidationDto;

            if (pinForValidationDto == null)
                throw new Exception("Object for validation is null");

            int[] pinDigits = StringDigitsToIntArrayConverter.GetDigits(pinForValidationDto.Pin);

            if (PinIsFourConsecutiveZeros(pinDigits))
                return new ValidationResult(false, "Pin cannot be 0000.");

            return new ValidationResult(true, null);
        }

        private bool PinIsFourConsecutiveZeros(int[] pinDigits)
        {
            bool allDigitsAreZeros = true;

            foreach (int pinDigit in pinDigits)
            {
                if (pinDigit != 0)
                    allDigitsAreZeros = false;
            }

            return allDigitsAreZeros;
        }
    }
}