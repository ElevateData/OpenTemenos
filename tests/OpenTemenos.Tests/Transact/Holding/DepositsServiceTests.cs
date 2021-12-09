using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class DepositsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient){ ReadResponseAsString = true };
}