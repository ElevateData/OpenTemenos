using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class HoldingerviceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);
}