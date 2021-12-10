using DataHub.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
[TestCategory("DataHub.AnalyticDataStore")]
public class AllCustomerProfitabilityMetricServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetAllCustomerProfitabilityMetricsAsync()
    {
        var result = _client.CustomerProfitabilityService.GetAllCustomerProfitabilityMetricsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}