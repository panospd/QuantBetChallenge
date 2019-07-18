using System;
using QuantBetChallenge.Core.Validation;

namespace QuantBetChallenge.Infrastructure.Validations.PinValidators
{
    public class PinLengthValidator : PinValidator, IValidator
    {
        public override ValidationResult Validate()
        {
            IPinForValidationDto pinForValidationDto = ValidationContext.ObjectInstance as IPinForValidationDto;
            
            if(pinForValidationDto == null)
                throw new Exception("Object for validation is null");

            if(pinForValidationDto.Pin.ToString().Length != 4)
                return new ValidationResult(false, "Pin is not 4 digits long.");

            return new ValidationResult(true, null);
        }
    }
}