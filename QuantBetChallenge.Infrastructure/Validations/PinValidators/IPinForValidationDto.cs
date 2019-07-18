using System.Collections.Generic;

namespace QuantBetChallenge.Infrastructure.Validations.PinValidators
{
    public interface IPinForValidationDto
    {
        int Pin { get; }
        IList<int> PastPins { get; }
        string BankAccount { get; }
        string SortCode { get; }
    }
}