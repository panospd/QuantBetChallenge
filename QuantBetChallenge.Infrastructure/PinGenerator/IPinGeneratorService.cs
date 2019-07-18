using QuantBetChallenge.Core;

namespace QuantBetChallenge.Infrastructure.PinGenerator
{
    public interface IPinGeneratorService
    {
        StandardResponse<int?> GeneratePin(ICustomerDetails customerDetails);
    }
}