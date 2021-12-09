using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class PaymentStopsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);
}