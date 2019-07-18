using System.Collections.Generic;

namespace QuantBetChallenge.Infrastructure.Validations.PinValidators
{
    public class PinForValidationDto : IPinForValidationDto
    {
        public PinForValidationDto(int pin, IList<int> pastPins, string bankAccount, string sortCode)
        {
            Pin = pin;
            PastPins = pastPins;
            BankAccount = bankAccount;
            SortCode = sortCode;
        }

        public int Pin { get; }
        public IList<int> PastPins { get; }
        public string BankAccount { get; }
        public string SortCode { get; }
    }
}