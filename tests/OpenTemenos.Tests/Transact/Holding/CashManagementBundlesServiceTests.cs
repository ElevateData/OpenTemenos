using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class CashManagementBundlesServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);
}