using QuantBetChallenge.Core;

namespace QuantBetChallenge.Infrastructure.PinGenerator
{
    public interface IPinGeneratorService
    {
        StandardResponse<string> GeneratePin(ICustomerDetails customerDetails);
    }
}