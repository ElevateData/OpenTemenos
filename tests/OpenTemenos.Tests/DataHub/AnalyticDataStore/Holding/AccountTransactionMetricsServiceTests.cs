using DataHub.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
public class AccountTransactionMetricsServiceTests
    : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetAccountTransactionMetricsAsync()
    {
        var result = _client.AccountTransactionService
            .GetAccountTransactionMetricsAsync(null, null)
            .Result;
        Assert.IsNotNull(result.Data);
    }
}