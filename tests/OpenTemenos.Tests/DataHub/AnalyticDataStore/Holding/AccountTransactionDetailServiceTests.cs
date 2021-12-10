using DataHub.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
public class AccountTransactionDetailsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetAccountTransactionDetailsAsync()
    {
        var result = _client.AccountTransactionDetailService
            .GetAccountTransactionDetailsAsync()
            .Result;
        Assert.IsNotNull(result.Data);
    }
}