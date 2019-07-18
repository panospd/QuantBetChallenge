using System;
using System.Collections.Generic;
using System.Text;
using QuantBetChallenge.Core.Validation;

namespace QuantBetChallenge.Core
{
    public class StandardResponse<T>
    {
        public StandardResponse(bool success, T result, IList<string> errorMessages)
        {
            Success = success;
            Result = result;
            ErrorMessages = errorMessages;
        }

        public bool Success { get; set; }
        public T Result { get; set; }
        public IList<string> ErrorMessages { get; set; }
    }
}
