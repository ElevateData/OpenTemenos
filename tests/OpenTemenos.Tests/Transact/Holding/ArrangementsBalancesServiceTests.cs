using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
[Ignore("All methods are flagged as obsolete")]
public class ArrangementsBalancesServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };
}