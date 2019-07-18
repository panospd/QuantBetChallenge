using System.ComponentModel.DataAnnotations;
using QuantBetChallenge.Core;
using ValidationResult = QuantBetChallenge.Core.Validation.ValidationResult;

namespace QuantBetChallenge.Infrastructure.Validations.PinValidators
{
    public abstract class PinValidator
    {
        public ValidatorType ValidatorType => ValidatorType.Pin;
        public ValidationContext ValidationContext { get; set; }

        public bool CanProcessValidation(ValidatorType validatorType)
        {
            return ValidatorType == validatorType;
        }

        public abstract ValidationResult Validate();

    }
}
