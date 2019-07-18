using System.ComponentModel.DataAnnotations;
using ValidationResult = QuantBetChallenge.Core.Validation.ValidationResult;

namespace QuantBetChallenge.Infrastructure.Validations.PinValidators
{
    public interface IValidator
    {
        ValidationResult Validate();
        ValidatorType ValidatorType { get; }
        ValidationContext ValidationContext { get; set; }
        bool CanProcessValidation(ValidatorType validatorType);
    }
}