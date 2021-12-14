using OpenTemenos.DataHubs.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
[TestCategory("DataHub.AnalyticDataStore")]
public class ProductTransactionMetricServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetProductTransactionMetricsAsync()
    {
        var result = _client.ProductTransactionService.GetProductTransactionMetricsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}