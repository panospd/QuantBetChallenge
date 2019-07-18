using System.Collections.Generic;
using QuantBetChallenge.Infrastructure.Validations.PinValidators;

namespace QuantBetChallenge.Infrastructure.Validations.Retriever
{
    public interface IValidatorsRetriever
    {
        IEnumerable<T> GetAll<T>();
    }
}