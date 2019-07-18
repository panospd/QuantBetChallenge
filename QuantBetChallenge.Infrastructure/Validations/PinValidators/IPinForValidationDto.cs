using System.Collections.Generic;

namespace QuantBetChallenge.Infrastructure.Validations.PinValidators
{
    public interface IPinForValidationDto
    {
        string Pin { get; }
        IList<string> PastPins { get; }
        string BankAccount { get; }
        string SortCode { get; }
    }
}