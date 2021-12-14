using OpenTemenos.DataHubs.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
[TestCategory("DataHub.AnalyticDataStore")]
public class AccountTransactionDetailServiceTests : CredentialManagement
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