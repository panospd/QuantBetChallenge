using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ValidationResult = QuantBetChallenge.Core.Validation.ValidationResult;

namespace QuantBetChallenge.Infrastructure.Validations.PinValidators.Runner
{
    public interface IPinValidationsRunner
    {
        ValidationContext ValidationContext { get; set; }
        IList<ValidationResult> Run();
    }
}