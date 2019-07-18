using System.Collections.Generic;

namespace QuantBetChallenge.Infrastructure.Validations.PinValidators
{
    public class PinForValidationDto : IPinForValidationDto
    {
        public PinForValidationDto(string pin, IList<string> pastPins, string bankAccount, string sortCode)
        {
            Pin = pin;
            PastPins = pastPins;
            BankAccount = bankAccount;
            SortCode = sortCode;
        }

        public string Pin { get; }
        public IList<string> PastPins { get; }
        public string BankAccount { get; }
        public string SortCode { get; }
    }
}