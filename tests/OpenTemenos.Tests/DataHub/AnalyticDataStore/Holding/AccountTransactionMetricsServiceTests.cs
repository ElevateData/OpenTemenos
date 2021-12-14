using OpenTemenos.DataHubs.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
[TestCategory("DataHub.AnalyticDataStore")]
public class AccountTransactionMetricServiceTests
    : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetAccountTransactionMetricsAsync()
    {
        var result = _client.AccountTransactionService
            .GetAccountTransactionMetricsAsync()
            .Result;
        Assert.IsNotNull(result.Data);
    }
}