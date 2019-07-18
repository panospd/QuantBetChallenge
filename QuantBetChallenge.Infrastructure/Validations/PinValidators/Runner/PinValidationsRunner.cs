using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using QuantBetChallenge.Infrastructure.Validations.Retriever;
using ValidationResult = QuantBetChallenge.Core.Validation.ValidationResult;

namespace QuantBetChallenge.Infrastructure.Validations.PinValidators.Runner
{
    public class PinValidationsRunner : IPinValidationsRunner
    {
        private readonly IValidatorsRetriever _validatorsRetriever;

        public PinValidationsRunner()
        :this(new ValidatorsRetriever())
        {
        }

        private PinValidationsRunner(IValidatorsRetriever validatorsRetriever)
        {
            _validatorsRetriever = validatorsRetriever;
        }

        public ValidationContext ValidationContext { get; set; }

        public IList<ValidationResult> Run()
        {
            if(ValidationContext == null)
                throw new Exception("Validation Context was null.");

            if(ValidationContext.ObjectInstance == null)
                throw new Exception("Validation Context object to validate was null.");

            List<ValidationResult> validationResults = new List<ValidationResult>();

            IReadOnlyCollection<IValidator> validators = GetValidators();

            foreach (var validator in validators)
            {
                validator.ValidationContext = ValidationContext;
                ValidationResult result = validator.Validate();
                validationResults.Add(result);
            }

            return validationResults;
        }

        private IReadOnlyCollection<IValidator> GetValidators()
        {
            return _validatorsRetriever.GetAll<IValidator>().Where(v => v.CanProcessValidation(ValidatorType.Pin)).ToArray();
        }
    }
}
